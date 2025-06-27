using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.Invitations.Queries;
using Tatawwa3.Application.Dtos.InvitationDtos;
using Tatawwa3.Application.Services;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.Invitations.Hnadler
{
    internal class GetSentInvitationsHandler : IRequestHandler<GetSentInvitationsQuery, List<SentInvitationDto>>
    {
        private readonly IVolunteerInvitationReprosatry _invitationRepo;
        private readonly IVolunteerProfileRepository _volunteerRepo;
        private readonly ITeamRepository _teamRepo;
        private readonly IOpportunity _opportunityRepo;

        public GetSentInvitationsHandler(
            IVolunteerInvitationReprosatry invitationRepo,
            IVolunteerProfileRepository volunteerRepo,
            ITeamRepository teamRepo,
            IOpportunity opportunityRepo)
        {
            _invitationRepo = invitationRepo;
            _volunteerRepo = volunteerRepo;
            _teamRepo = teamRepo;
            _opportunityRepo = opportunityRepo;
        }

        public async Task<List<SentInvitationDto>> Handle(GetSentInvitationsQuery request, CancellationToken cancellationToken)
        {
            var invitations = _invitationRepo.GetAll().ToList();
            var result = new List<SentInvitationDto>();

            foreach (var inv in invitations)
            {
                var volunteer = _volunteerRepo.GetByID(inv.VolunteerId);
                var user = volunteer?.User;

                string invitationName = "غير محدد";
                string type = "";

                if (!string.IsNullOrEmpty(inv.TeamId))
                {
                    var team = _teamRepo.GetByID(inv.TeamId);
                    invitationName = team?.Name ?? "غير محدد";
                    type = "فريق";
                }
                else if (!string.IsNullOrEmpty(inv.OpportunityId))
                {
                    var opp = _opportunityRepo.GetByID(inv.OpportunityId);
                    invitationName = opp?.Title ?? "غير محدد";
                    type = "فرصة تطوعية";
                }

                var dto = inv.Map<SentInvitationDto>();
                dto.VolunteerFullName = user?.UserName ?? "غير معروف";
                dto.VolunteerEmail = user?.Email ?? "غير معروف";
                dto.InvitationType = type;
                dto.InvitationName = invitationName;

                result.Add(dto);
            }

            return result;
        }

          
        }
    }
    

