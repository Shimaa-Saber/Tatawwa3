using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Notifications;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.Services
{
    public class NotificationPreferenceService : INotificationPreferenceService
    {
        private readonly Tatawwa3DbContext _context;

        public NotificationPreferenceService(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<NotificationPreferenceDto> GetPreferencesAsync(string userId)
        {
            var pref = await _context.notificationPreferences
                .FirstOrDefaultAsync(p => p.UserId == userId);

            if (pref == null)
            {
                pref = new NotificationPreference {
                    Id = Guid.NewGuid().ToString(),
                    UserId = userId };
                _context.notificationPreferences.Add(pref);
                await _context.SaveChangesAsync();
            }

            return new NotificationPreferenceDto
            {
                NotifyOnApplicationAccepted = pref.NotifyOnApplicationAccepted,
                NotifyOnCertificateIssued = pref.NotifyOnCertificateIssued,
                NotifyOnOpportunityRecommendations = pref.NotifyOnOpportunityRecommendations
            };
        }

        public async Task SavePreferencesAsync(string userId, NotificationPreferenceDto dto)
        {
            var pref = await _context.notificationPreferences
                .FirstOrDefaultAsync(p => p.UserId == userId);

            if (pref == null)
            {
                pref = new NotificationPreference { UserId = userId };
                _context.notificationPreferences.Add(pref);
            }

            pref.NotifyOnApplicationAccepted = dto.NotifyOnApplicationAccepted;
            pref.NotifyOnCertificateIssued = dto.NotifyOnCertificateIssued;
            pref.NotifyOnOpportunityRecommendations = dto.NotifyOnOpportunityRecommendations;

            await _context.SaveChangesAsync();
        }

        public async Task<UpdateOrgNotificationPreferencesDto> GetOrgPreferencesAsync(string userId)
        {
            var pref = await _context.notificationPreferences
               .FirstOrDefaultAsync(p => p.UserId == userId);

            if (pref == null)
            {
                pref = new NotificationPreference
                {
                    Id = Guid.NewGuid().ToString(),
                    UserId = userId
                };
                _context.notificationPreferences.Add(pref);
                await _context.SaveChangesAsync();
            }

            return new UpdateOrgNotificationPreferencesDto
            {
                NotifyOnNewVolunteerApplication = pref.NotifyOnNewVolunteerApplication,
                NotifyOnVolunteerApplicationUnderReview = pref.NotifyOnVolunteerApplicationUnderReview,
                NotifyOnOpportunityCompleted = pref.NotifyOnOpportunityCompleted
            };
        }

        public async Task UpdateOrgPreferencesAsync(string userId, UpdateOrgNotificationPreferencesDto dto)
        {
            var pref = await _context.notificationPreferences
                 .FirstOrDefaultAsync(p => p.UserId == userId);

            if (pref == null)
            {
                pref = new NotificationPreference { UserId = userId };
                _context.notificationPreferences.Add(pref);
            }

            pref.NotifyOnNewVolunteerApplication = dto.NotifyOnNewVolunteerApplication;
            pref.NotifyOnVolunteerApplicationUnderReview = dto.NotifyOnVolunteerApplicationUnderReview;
            pref.NotifyOnOpportunityCompleted = dto.NotifyOnOpportunityCompleted;

            _context.notificationPreferences.Update(pref);
            await _context.SaveChangesAsync();
        }

       
    }

}
