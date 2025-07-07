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
    public record RejectInvitationCommand(string InvitationId) : IRequest<string>;


    public class RejectInvitationHandler : IRequestHandler<RejectInvitationCommand, string>
    {
        private readonly IVolunteerInvitationReprosatry _invitationRepo;
        private readonly ITeamRepository _teamRepo;
        private readonly IOpportunity _opportunityRepo;
        private readonly IVolunteerProfileRepository _volunteerRepo;
        private readonly INotificationService _notificationService;
        private readonly Tatawwa3DbContext _context;

        public RejectInvitationHandler(IVolunteerInvitationReprosatry invitationRepo
            , 
                                       ITeamRepository teamRepo, 
                                       IOpportunity opportunityRepo, 
                                       IVolunteerProfileRepository volunteerRepo, 
                                       INotificationService notificationService,
                                       Tatawwa3DbContext context

            )
        {
            _invitationRepo = invitationRepo;
            _teamRepo = teamRepo;
            _notificationService = notificationService;
            _opportunityRepo = opportunityRepo;
            _volunteerRepo = volunteerRepo;
            _context = context;
        }

        public async Task<string> Handle(RejectInvitationCommand request, CancellationToken cancellationToken)
        {
            var invitation =await _invitationRepo.GetByIDAsync(request.InvitationId);
            if (invitation == null) return "الدعوة غير موجودة.";

            invitation.Status = InvitationStatus.Rejected;
            _context.VolunteerInvitations.Update(invitation);

            // Get volunteer name
            var volunteer = await _volunteerRepo.FirstOrDefaultAsync(v => v.Id == invitation.VolunteerId);
            var volunteerName = volunteer?.User?.FullName ?? "متطوع";

            string? targetUserId = null;
            string message = "";

            if (invitation.TeamId != null)
            {
                var team = await _teamRepo.FirstOrDefaultAsync(t => t.Id == invitation.TeamId);
                if (team != null && team.ApplicationUser != null)
                {
                    targetUserId = team.ApplicationUser.Id;
                    message = $"قام {volunteerName} برفض دعوة الانضمام إلى الفريق: {team.Name}";
                }
            }

            if (invitation.OpportunityId != null)
            {
                var opportunity = await _opportunityRepo.FirstOrDefaultAsync(o => o.Id == invitation.OpportunityId);
                if (opportunity != null && opportunity.ApplicationUser != null)
                {
                    targetUserId = opportunity.ApplicationUser.Id;
                    message = $"قام {volunteerName} برفض دعوة الانضمام إلى الفرصة: {opportunity.Title}";
                }
            }

            await _invitationRepo.SaveChangesAsync();

            if (!string.IsNullOrEmpty(targetUserId))
            {
                await _notificationService.SendNotificationAsync(
                    userId: targetUserId,
                    title: "❌ تم رفض الدعوة",
                    message: message
                );
            }

            return "تم رفض الدعوة.";
        }

    }

}
