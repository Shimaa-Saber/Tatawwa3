﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.Services
{
    public class VolunteerMangmentService : IApplicationService
    {
        private readonly Tatawwa3DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly INotificationRepository _notificationRepository;
        private readonly IVolunteerProfileRepository _volunteerRepo;

        public VolunteerMangmentService(Tatawwa3DbContext context, INotificationService notificationService,
            INotificationRepository notificationRepository, IVolunteerProfileRepository volunteerRepo
            )
        {
            _context = context;
            _notificationService = notificationService;
            _notificationRepository = notificationRepository;
            _volunteerRepo = volunteerRepo;
        }

        public async Task<List<ApplicationDto>> GetAllApplicationsByOrganizationAsync(string orgUserId)
        {
            return await _context.Applications
                .Include(a => a.Volunteer)
                    .ThenInclude(v => v.User)
                .Include(a => a.Opportunity)
                .Where(a => a.Opportunity.Id == orgUserId)
                .Select(a => new ApplicationDto
                {
                    Id = a.Id,
                    OpportunityTitle = a.Opportunity.Title,
                    profileImage = a.Volunteer.ProfilePictureUrl,
                    VolunteerId = a.VolunteerID,
                    FullName = a.Volunteer.User.FullName,
                    Status = a.Status.ToString(),
                    AppliedAt = a.CreatedAt
                })
                .ToListAsync();
        }


        public async Task<bool> AcceptApplicationAsync(string applicationId)
        {
            var application = await _context.Applications
           .Include(a => a.Volunteer)
           .ThenInclude(v => v.User)
           .Include(a => a.Opportunity) 
           .FirstOrDefaultAsync(a => a.Id == applicationId);
            if (application == null)
                return false;

            application.Status = ApplicationStatus.Accepted;
            _context.Applications.Update(application);
            await _context.SaveChangesAsync();
            var volunteer = await _volunteerRepo
                .GetWithIncludes(v => v.User.NotificationPreference)
                .FirstOrDefaultAsync(v => v.Id == application.VolunteerID);
            var preferences = volunteer?.User?.NotificationPreference;
            if (preferences?.NotifyOnApplicationAccepted == true)
            {
                await _notificationService.SendNotificationAsync(
            userId: application.Volunteer.UserID,
            title: "تم قبول طلبك",
            message: $"تم قبولك في الفرصة: {application.Opportunity.Title}"

   );
            }



            return true;
        }

        public async Task<bool> RejectApplicationAsync(string applicationId)
        {
            var application = await _context.Applications
           .Include(a => a.Volunteer)
           .ThenInclude(v => v.User)
           .Include(a => a.Opportunity)
           .FirstOrDefaultAsync(a => a.Id == applicationId);
            if (application == null)
                return false;

            application.Status = ApplicationStatus.Rejected;

            _context.Applications.Update(application);
            await _context.SaveChangesAsync();

            await _notificationService.SendNotificationAsync(
           userId: application.Volunteer.UserID,
           title: "تم رفض طلبك",
           message: $"تم رفض طلبك في الفرصة: {application.Opportunity.Title}");


            
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

        public async Task<List<ApplicationDto>> GetApplicationsByNameAsync(string name, string opportunityId)
        {
            var apps = await _context.Applications
                .Include(a => a.Volunteer)
                    .ThenInclude(v => v.User)
                .Where(a => a.OpportunityID == opportunityId && a.Volunteer.User.FullName.Contains(name))
                .Select(a => new ApplicationDto
                {
                    Id = a.Id,
                    OpportunityTitle = a.Opportunity.Title,
                    profileImage=a.Volunteer.ProfilePictureUrl,
                    VolunteerId = a.VolunteerID,
                    FullName = a.Volunteer.User.FullName,
                    Status = a.Status.ToString(),
                    AppliedAt = a.CreatedAt
                })
                .ToListAsync();

            return apps;
        }

        public async Task<List<ApplicationDto>> GetApplicationsByStatusAsync(string status,string opportunityId)
        {
            if (!Enum.TryParse<ApplicationStatus>(status, true, out var statusEnum))
            {
                return new List<ApplicationDto>(); 
            }

            var apps = await _context.Applications
                .Include(a => a.Volunteer)
                    .ThenInclude(v => v.User)
                .Where(a => a.OpportunityID == opportunityId && a.Status == statusEnum)
                .Select(a => new ApplicationDto
                {
                    Id = a.Id,
                    OpportunityTitle = a.Opportunity.Title,
                    profileImage = a.Volunteer.ProfilePictureUrl,
                    VolunteerId = a.VolunteerID,
                    FullName = a.Volunteer.User.FullName,
                    Status = a.Status.ToString(),
                    AppliedAt = a.CreatedAt
                })
                .ToListAsync();

            return apps;
        }

        public async Task<List<ApplicationDto>> GetApplicationsByDateAsync(DateTime date, string opportunityId)
        {
            return await _context.Applications
                .Include(a => a.Volunteer)
                    .ThenInclude(v => v.User)
                .Where(a => a.OpportunityID == opportunityId && a.CreatedAt.Date == date.Date)
                .Select(a => new ApplicationDto
                {
                    Id = a.Id,
                    OpportunityTitle = a.Opportunity.Title,
                    profileImage = a.Volunteer.ProfilePictureUrl,
                    VolunteerId = a.VolunteerID,
                    FullName = a.Volunteer.User.FullName,
                    Status = a.Status.ToString(),
                    AppliedAt = a.CreatedAt
                })
                .ToListAsync();
        }

        public async Task<ApplicationStatisticsDto> GetApplicationStatisticsAsync(string opp_id)
        {
            var applications = await _context.Applications.ToListAsync();

            return new ApplicationStatisticsDto
            {
                Total = applications.Where(id => id.OpportunityID == opp_id).Count(),
                Accepted = applications.Where(id=>id.OpportunityID==opp_id).Count(a => a.Status == ApplicationStatus.Accepted),
                Rejected = applications.Where(id => id.OpportunityID == opp_id).Count(a => a.Status == ApplicationStatus.Rejected),
                Pending = applications.Where(id => id.OpportunityID == opp_id).Count(a => a.Status == ApplicationStatus.Pending)
            };
        }


    }
}
