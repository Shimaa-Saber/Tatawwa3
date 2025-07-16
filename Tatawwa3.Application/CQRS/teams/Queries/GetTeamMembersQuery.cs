using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos;

namespace Tatawwa3.Application.CQRS.teams.Queries
{
    public class GetTeamMembersQuery : IRequest<List<TeamMemberDto>>
    {
        public string TeamId { get; set; }

        public GetTeamMembersQuery(string teamId)
        {
            TeamId = teamId;
        }
    }
}
