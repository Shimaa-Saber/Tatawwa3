using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.Services
{
    public class JoinRequestService: IJoinRequestService
    {
        private readonly ITeamRepository _teamRepo;
        private readonly IGeneric<JoinRequest> _joinRequestRepo;
        private readonly Tatawwa3DbContext _tatawwa3DbContext;
        private readonly IGeneric<VolunteerProfile> _volunteerRepo;
        private readonly INotificationService _notificationService;
        public JoinRequestService(
            ITeamRepository teamRepo,
            IGeneric<JoinRequest> joinRequestRepo,
            Tatawwa3DbContext tatawwa3DbContext,
            IGeneric<VolunteerProfile> volunteerRepo,
            INotificationService notificationService)
        {
            _teamRepo = teamRepo;
            _joinRequestRepo = joinRequestRepo;
            _tatawwa3DbContext = tatawwa3DbContext;
            _volunteerRepo = volunteerRepo;
            _notificationService = notificationService;
        }
        public async Task<string> AcceptJoinRequestAsync(string requestId)
        {
            var request = await _tatawwa3DbContext.JoinRequests.Include(a => a.Volunteer)
           .ThenInclude(v => v.User).FirstOrDefaultAsync(a => a.Id == requestId);
            if (request == null)
                return "الطلب غير موجود.";

            request.Status = RequestStatus.Accepted;
            await _teamRepo.AddVolunteerToTeamAsync(request.TeamId, request.VolunteerId);

            _joinRequestRepo.UpdateByEntity(request);
            await _joinRequestRepo.SaveChangesAsync();

            var team = await _teamRepo.FirstOrDefaultAsync(t => t.Id == request.TeamId);
            var volunteer = await _volunteerRepo.FirstOrDefaultAsync(v => v.Id == request.VolunteerId);

            if (volunteer != null)
            {
                await _notificationService.SendNotificationAsync(
                    userId: volunteer.UserID,
                    title: "تم قبول طلب الانضمام لفريق✅",
                    message: $"تم قبول طلب انضمامك إلى الفريق: {team?.Name}"
                );
            }

            return "تم قبول الطلب.";
        }


        public async Task<string> RejectJoinRequestAsync(string requestId)
        {
            var request = await _tatawwa3DbContext.JoinRequests.Include(a => a.Volunteer)
           .ThenInclude(v => v.User).FirstOrDefaultAsync(a => a.Id == requestId);
            if (request == null)
                return "الطلب غير موجود.";

            request.Status = RequestStatus.Rejected;

            _joinRequestRepo.UpdateByEntity(request);
            await _joinRequestRepo.SaveChangesAsync();

            var team = await _teamRepo.FirstOrDefaultAsync(t => t.Id == request.TeamId);
            var volunteer = await _volunteerRepo.FirstOrDefaultAsync(v => v.Id == request.VolunteerId);

            if (volunteer != null)
            {
                await _notificationService.SendNotificationAsync(
                    userId: volunteer.UserID,
                    title: " تم رفض طلب الانضمام لفريق❌",
                    message: $"تم رفض طلب انضمامك إلى الفريق: {team?.Name}"
                );
            }

            return "تم رفض الطلب.";
        }

    }
}
