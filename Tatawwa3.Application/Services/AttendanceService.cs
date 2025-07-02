using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Attendace;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IGeneric<Participation> _participationRepo;
        private readonly Tatawwa3DbContext _context;

        public AttendanceService(IGeneric<Participation> participationRepo,
            Tatawwa3DbContext context
            )
        {
            _participationRepo = participationRepo;
            _context = context;
        }

        public async Task<List<AttendanceVolunteerDto>> GetOpportunityParticipantsAsync(string opportunityId)
        {
            var participations = await _participationRepo.GetQueryable()
                .Where(p => p.OpportunityId == opportunityId)
                .Include(p => p.Volunteer)
                    .ThenInclude(v => v.User)
                .Include(p => p.Attendances)
                .ToListAsync();

            return participations.Select(p => new AttendanceVolunteerDto
            {
                VolunteerId = p.VolunteerID,
                FullName = p.Volunteer.User.FullName,
                Email = p.Volunteer.User.Email,
                ParticipationId = p.Id,
                AttendanceStatus = p.Attendances?.Any(a => a.Status == AttendanceStatus.Present) == true ? "حضر" : "غاب",
                ApprovedHours = p.TotalAttendedHours,
                Comment = p.Attendances?.FirstOrDefault()?.Comment
            }).ToList();
        }

        public async Task<bool> UpdateAttendanceAsync(UpdateAttendanceDto dto)
        {
            var participation = await _context.Participations
                .Include(p => p.Attendances)
                .FirstOrDefaultAsync(p => p.Id == dto.ParticipationId);

            if (participation == null)
                return false;

            participation.TotalAttendedHours = dto.ApprovedHours;

            var existingAttendance = participation.Attendances?.FirstOrDefault();

            if (existingAttendance != null)
            {
                existingAttendance.Status = dto.Status;
                existingAttendance.Comment = dto.Comment;
            }
            else
            {
                participation.Attendances = new List<Attendance>
        {
            new Attendance
            {
                Id = Guid.NewGuid().ToString(),
                ParticipationID = participation.Id,
                Status = dto.Status,
                Comment = dto.Comment,
                AttendanceDate = DateTime.UtcNow
            }
        };
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<byte[]> ExportAttendanceReportPdfAsync(string opportunityId)
        {
            var participants = await _context.Participations
                .Include(p => p.Volunteer).ThenInclude(v => v.User)
                .Where(p => p.OpportunityId == opportunityId)
                .ToListAsync();

            
            QuestPDF.Settings.License = LicenseType.Community;

            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(20);
                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(120); 
                            columns.RelativeColumn();    
                            columns.ConstantColumn(60);  
                            columns.ConstantColumn(100); 
                            columns.ConstantColumn(100); 
                            columns.ConstantColumn(80);  
                        });

                      
                        table.Header(header =>
                        {
                            header.Cell().Element(CellStyle).Text("الاسم الكامل");
                            header.Cell().Element(CellStyle).Text("الإيميل");
                            header.Cell().Element(CellStyle).Text("الساعات");
                            header.Cell().Element(CellStyle).Text("أول حضور");
                            header.Cell().Element(CellStyle).Text("آخر حضور");
                            header.Cell().Element(CellStyle).Text("الحالة");
                        });

                   
                        foreach (var p in participants)
                        {
                            table.Cell().Element(CellStyle).Text(p.Volunteer.User.FullName);
                            table.Cell().Element(CellStyle).Text(p.Volunteer.User.Email);
                            table.Cell().Element(CellStyle).Text(p.TotalAttendedHours.ToString());
                            table.Cell().Element(CellStyle).Text(p.FirstCheckIn.ToString("yyyy-MM-dd"));
                            table.Cell().Element(CellStyle).Text(p.LastCheckOut.ToString("yyyy-MM-dd"));
                            table.Cell().Element(CellStyle).Text(p.Status.ToString());
                        }
                    });
                });
            });

            return document.GeneratePdf();

            static IContainer CellStyle(IContainer container) =>
                container.Padding(5).BorderBottom(1).BorderColor(Colors.Grey.Lighten2);
        }


        public async Task<byte[]> ExportAttendanceReportExcelAsync(string opportunityId)
        {
            var data = await _context.Attendances
                .Where(a => a.Participation.OpportunityId == opportunityId)
                .Select(a => new
                {
                    VolunteerName = a.Participation.Volunteer.User.FullName,
                    CheckIn = a.CheckInTime,
                    CheckOut = a.CheckOutTime,
                    Duration = (a.CheckOutTime - a.CheckInTime).TotalHours
                })
                .ToListAsync();

            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Attendance");

            worksheet.Cell(1, 1).Value = "Volunteer Name";
            worksheet.Cell(1, 2).Value = "Check In";
            worksheet.Cell(1, 3).Value = "Check Out";
            worksheet.Cell(1, 4).Value = "Duration (hrs)";

            for (int i = 0; i < data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data[i].VolunteerName;
                worksheet.Cell(i + 2, 2).Value = data[i].CheckIn.ToString("g");
                worksheet.Cell(i + 2, 3).Value = data[i].CheckOut.ToString("g");
                worksheet.Cell(i + 2, 4).Value = data[i].Duration;
            }

            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            return stream.ToArray();
        }



    }
}
