using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerAttendanceAndCert;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.Services
{
    public class VolunteerService : IVolunteerService
    {
        private readonly Tatawwa3DbContext _context;
        private readonly IPdfGenerator _pdfGenerator; 

        public VolunteerService(Tatawwa3DbContext context, IPdfGenerator pdfGenerator)
        {
            _context = context;
            _pdfGenerator = pdfGenerator;
        }

        public async Task<VolunteerSummaryDto> GetVolunteerSummaryAsync(string userId)
        {
            var volunteer = await _context.VolunteerProfiles.FirstOrDefaultAsync(v => v.UserID == userId);
            if (volunteer == null)
                throw new Exception("Volunteer profile not found.");

            var opportunityCount = await _context.Participations.CountAsync(p => p.VolunteerID == volunteer.Id);
            var totalHours = await _context.Participations
                .Where(p => p.VolunteerID == volunteer.Id)
                .SumAsync(p => p.TotalAttendedHours);

            var certificates = await _context.Certificates
                .CountAsync(c => c.VolunteerID == volunteer.Id);

            return new VolunteerSummaryDto
            {
                TotalOpportunities = opportunityCount,
                TotalHours = totalHours,
                TotalCertificates = certificates
            };
        }


        public async Task<List<ParticipationDto>> GetVolunteerParticipationsAsync(string userId)
        {
            var profile = await _context.VolunteerProfiles.FirstOrDefaultAsync(v => v.UserID == userId);
            if (profile == null)
                throw new Exception("Volunteer profile not found.");

            var participations = await _context.Participations
                .Include(p => p.Opportunity)
                .Where(p => p.VolunteerID == profile.Id)
                .Select(p => new ParticipationDto
                {
                    OpportunityTitle = p.Opportunity.Title,
                    Opportunity_discrption = p.Opportunity.Description,
                    Date = p.CreatedAt,
                    Hours = p.TotalAttendedHours,
                    Status = p.Status.ToString()
                })
                .ToListAsync();

            return participations;
        }


        public async Task<List<CertificateDto>> GetVolunteerCertificatesAsync(string userId)
        {
            var certs = await _context.Certificates
                .Include(c => c.Volunteer)
                .Include(c => c.Participation)
                    .ThenInclude(p => p.Opportunity)
                        .ThenInclude(o => o.Organization)
                .Where(c => c.Volunteer.UserID == userId) 
                .Select(c => new CertificateDto
                {
                    Id = c.Id,
                    Title = c.Participation.Opportunity.Title,
                    TotalHours = c.TotalHours,
                    IssueDate = c.IssueDate,
                    OrganizationName = c.Participation.Opportunity.Organization.OrganizationName,
                    DownloadUrl = $"https://tatawwa3.runasp.net.com/api/certificates/download/{c.Id}"
                })
                .ToListAsync();

            return certs;
        }

        public async Task<byte[]> DownloadCertificateAsync(string certificateId)
        {
            var cert = await _context.Certificates
            .Include(c => c.Volunteer)
        .ThenInclude(v => v.User)
             .Include(c => c.Participation)
        .ThenInclude(p => p.Opportunity)
            .ThenInclude(o => o.Organization)
           .FirstOrDefaultAsync(c => c.Id == certificateId);


            if (cert == null)
                throw new Exception("الشهادة غير موجودة");

            return _pdfGenerator.GenerateCertificatePdf(cert);
        }
    }

}


