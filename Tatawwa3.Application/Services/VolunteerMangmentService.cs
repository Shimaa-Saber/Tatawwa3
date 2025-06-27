using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerMangement.Queries;
using Tatawwa3.Application.Dtos.VolunteerMangement;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.Services
{
    public class VolunteerMangmentService : IApplicationService
    {
        private readonly Tatawwa3DbContext _context;

        public VolunteerMangmentService(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<List<ApplicationDto>> GetAllApplicationsAsync()
        {
            return await _context.Applications
                .Include(a => a.Volunteer)
                    .ThenInclude(v => v.User)
                .Select(a => new ApplicationDto
                {
                    VolunteerId = a.VolunteerID,
                    FullName = a.Volunteer.User.FullName,
                    Status = a.Status.ToString(),
                    AppliedAt = a.CreatedAt
                }).ToListAsync();
        }


        public async Task<bool> AcceptApplicationAsync(string applicationId)
        {
            var application = await _context.Applications.FindAsync(applicationId);
            if (application == null)
                return false;

            application.Status = ApplicationStatus.Accepted;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RejectApplicationAsync(string applicationId)
        {
            var application = await _context.Applications.FindAsync(applicationId);
            if (application == null)
                return false;

            application.Status = ApplicationStatus.Rejected;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AddNoteAsync(string applicationId, string note)
        {
            var application = await _context.Applications.FindAsync(applicationId);
            if (application == null)
                return false;

            application.Note = note;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<VolunteerProfileDto> GetVolunteerProfileAsync(string userId)
        {
            var profile = await _context.VolunteerProfiles
                .Include(v => v.User)
                .FirstOrDefaultAsync(v => v.UserID == userId);

            if (profile == null)
                throw new Exception("Volunteer profile not found.");

            return profile.Map<VolunteerProfileDto>();
        }

        public async Task<List<ApplicationDto>> GetApplicationsByNameAsync(string name)
        {
            var apps = await _context.Applications
                .Include(a => a.Volunteer)
                    .ThenInclude(v => v.User)
                .Where(a => a.Volunteer.User.FullName.Contains(name))
                .Select(a => new ApplicationDto
                {
                    VolunteerId = a.VolunteerID,
                    FullName = a.Volunteer.User.FullName,
                    Status = a.Status.ToString(),
                    AppliedAt = a.CreatedAt
                })
                .ToListAsync();

            return apps;
        }

        public async Task<List<ApplicationDto>> GetApplicationsByStatusAsync(string status)
        {
            var apps = await _context.Applications
                .Include(a => a.Volunteer)
                    .ThenInclude(v => v.User)
                .Where(a => a.Status.ToString().ToLower() == status.ToLower())
                .Select(a => new ApplicationDto
                {
                    VolunteerId = a.VolunteerID,
                    FullName = a.Volunteer.User.FullName,
                    Status = a.Status.ToString(),
                    AppliedAt = a.CreatedAt
                })
                .ToListAsync();

            return apps;
        }
        public async Task<List<ApplicationDto>> GetApplicationsByDateAsync(DateTime date)
        {
            return await _context.Applications
                .Include(a => a.Volunteer)
                    .ThenInclude(v => v.User)
                .Where(a => a.CreatedAt.Date == date.Date)
                .Select(a => new ApplicationDto
                {
                    VolunteerId = a.VolunteerID,
                    FullName = a.Volunteer.User.FullName,
                    Status = a.Status.ToString(),
                    AppliedAt = a.CreatedAt
                })
                .ToListAsync();
        }
        public async Task<ApplicationStatisticsDto> GetApplicationStatisticsAsync()
        {
            var applications = await _context.Applications.ToListAsync();

            return new ApplicationStatisticsDto
            {
                Total = applications.Count,
                Accepted = applications.Count(a => a.Status == ApplicationStatus.Accepted),
                Rejected = applications.Count(a => a.Status == ApplicationStatus.Rejected),
                Pending = applications.Count(a => a.Status == ApplicationStatus.Pending)
            };
        }


    }
}
