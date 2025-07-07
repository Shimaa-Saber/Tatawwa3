using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.Notifications.Commands
{
    public record AcceptInvitationCommand(string InvitationId) : IRequest<string>;

    // Handlers/AcceptInvitationHandler.cs
    public class AcceptInvitationHandler : IRequestHandler<AcceptInvitationCommand, string>
    {
        private readonly IVolunteerInvitationReprosatry _invitationRepo;
        private readonly ITeamRepository _teamRepo;
        private readonly IOpportunity _opportunityRepo;
        private readonly IVolunteerProfileRepository _volunteerRepo;
        private readonly INotificationService _notificationService;
         private readonly Tatawwa3DbContext _context;

        public AcceptInvitationHandler(
            IVolunteerInvitationReprosatry invitationRepo,
            ITeamRepository teamRepo,
            IOpportunity opportunityRepo,
            IVolunteerProfileRepository volunteerRepo,
            INotificationService notificationService,
            Tatawwa3DbContext context



            )
        {
            _invitationRepo = invitationRepo;
            _teamRepo = teamRepo;
            _opportunityRepo = opportunityRepo;
            _volunteerRepo = volunteerRepo;
            _notificationService = notificationService;
            _context = context;
        }

        public async Task<string> Handle(AcceptInvitationCommand request, CancellationToken cancellationToken)
        {
            var invitation =await _invitationRepo.GetByIDAsync(request.InvitationId);
            if (invitation == null) return "الدعوة غير موجودة.";

            invitation.Status = InvitationStatus.Accepted;
            _context.VolunteerInvitations.Update(invitation);
          //  await _context.SaveChangesAsync();

            // Get volunteer name
            var volunteer = await _volunteerRepo.FirstOrDefaultAsync(v => v.Id == invitation.VolunteerId);
            var volunteerName = volunteer?.User?.FullName ?? "متطوع";

            string? targetUserId = null;
            string message = "";

            if (invitation.TeamId != null)
            {
                await _teamRepo.AddVolunteerToTeamAsync(invitation.TeamId, invitation.VolunteerId);

                var team = await _teamRepo.FirstOrDefaultAsync(t => t.Id == invitation.TeamId);
                targetUserId = team?.ApplicationUser?.Id;
                message = $"قام {volunteerName} بقبول دعوة الانضمام إلى الفريق: {team?.Name}";
            }

            if (invitation.OpportunityId != null)
            {
                await _opportunityRepo.AddVolunteerToOpportunityAsync(invitation.OpportunityId, invitation.VolunteerId);

                var opportunity = await _opportunityRepo.FirstOrDefaultAsync(o => o.Id == invitation.OpportunityId);
                targetUserId = opportunity?.ApplicationUser.Id;
                message = $"قام {volunteerName} بقبول دعوة الانضمام إلى الفرصة: {opportunity?.Title}";
            }

            await _invitationRepo.SaveChangesAsync();

            if (!string.IsNullOrEmpty(targetUserId))
            {
                await _notificationService.SendNotificationAsync(
                    userId: targetUserId,
                    title: "📨 تم قبول الدعوة",
                    message: message
                );
            }

            return "تم قبول الدعوة بنجاح.";
        }

    }

}
