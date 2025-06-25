using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.VolunteerTeams;
using MediatR;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class GetVolunteerTeamsHandler : IRequestHandler<GetVolunteerTeamsQuery, List<VolunteerTeamDto>>
    {
        public Task<List<VolunteerTeamDto>> Handle(GetVolunteerTeamsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
