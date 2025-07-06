using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.Invitations.Commands;
using Tatawwa3.Application.Dtos.InvitationDtos;
using Tatawwa3.Application.Services;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Repositorirs;

namespace Tatawwa3.Application.CQRS.Invitations.Hnadler
{

    internal class AddInvitationHandler : IRequestHandler<AddInvitationCommand, string>
    {

        private readonly IVolunteerProfileRepository _volunteerRepo;
        private readonly ITeamRepository _teamRepo;
        private readonly IOpportunity _opportunityRepo;
        private readonly IVolunteerInvitationReprosatry _invitationRepo;

        public AddInvitationHandler(
        IVolunteerProfileRepository volunteerRepo,
        ITeamRepository teamRepo,
        IOpportunity opportunityRepo,
        IVolunteerInvitationReprosatry invitationRepo)
        {
            _volunteerRepo = volunteerRepo;
            _teamRepo = teamRepo;
            _opportunityRepo = opportunityRepo;
            _invitationRepo = invitationRepo;
        }
        public async Task<string> Handle(AddInvitationCommand request, CancellationToken cancellationToken)
        {
            var dto = request.addInvitaon;

            var volunteer = await _volunteerRepo.FirstOrDefaultAsync(v => v.User.FullName == dto.VolunteerFullName);
            if (volunteer == null)
                throw new Exception("المتطوع غير موجود");

            string? teamId = null;
            string? opportunityId = null;

            if (dto.InvitationType == InvitationType.JoinTeam)
            {
                var team = await _teamRepo.FirstOrDefaultAsync(t => t.Name == dto.TeamName);
                if (team == null)
                    throw new Exception("الفريق غير موجود");
                teamId = team.Id;
            }

            if (dto.InvitationType == InvitationType.JoinOpportunity)
            {
                var opportunity = await _opportunityRepo.FirstOrDefaultAsync(o => o.Title == dto.OpportunityTitle);
                if (opportunity == null)
                    throw new Exception("الفرصة غير موجودة");
                opportunityId = opportunity.Id;
            }
            var invitation = dto.Map<VolunteerInvitation>();
            invitation.Id = Guid.NewGuid().ToString();
            invitation.VolunteerId = volunteer.Id;
            invitation.TeamId = teamId;
            invitation.OpportunityId = opportunityId;
            invitation.Status = InvitationStatus.Pending;
            invitation.SentAt = DateTime.UtcNow;

            _invitationRepo.Add(invitation);
            await _invitationRepo.SaveChangesAsync();
            return "تم ارسال الدعوه";

        }
    }
}
