using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;

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

        public AcceptInvitationHandler(
            IVolunteerInvitationReprosatry invitationRepo,
            ITeamRepository teamRepo,
            IOpportunity opportunityRepo,
            IVolunteerProfileRepository volunteerRepo)
        {
            _invitationRepo = invitationRepo;
            _teamRepo = teamRepo;
            _opportunityRepo = opportunityRepo;
            _volunteerRepo = volunteerRepo;
        }

        public async Task<string> Handle(AcceptInvitationCommand request, CancellationToken cancellationToken)
        {
            var invitation =  _invitationRepo.GetByID(request.InvitationId);
            if (invitation == null) return "الدعوة غير موجودة.";

            invitation.Status = InvitationStatus.Accepted;

            if (invitation.TeamId != null)
                await _teamRepo.AddVolunteerToTeamAsync(invitation.TeamId, invitation.VolunteerId);

            if (invitation.OpportunityId != null)
                await _opportunityRepo.AddVolunteerToOpportunityAsync(invitation.OpportunityId, invitation.VolunteerId);

            await _invitationRepo.SaveChangesAsync();
            return "تم قبول الدعوة بنجاح.";
        }
    }

}
