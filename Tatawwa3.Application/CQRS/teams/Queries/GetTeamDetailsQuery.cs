using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.teams.Queries
{
    public class GetTeamDetailsQuery: IRequest<TeamDetailsDto>
    {
        public string TeamId { get; set; }
        public GetTeamDetailsQuery(string teamId)
        {
            TeamId = teamId;
        }

    }

    public class GetTeamDetailsHandler : IRequestHandler<GetTeamDetailsQuery, TeamDetailsDto>
    {
        private readonly ITeamService _teamService;

        public GetTeamDetailsHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<TeamDetailsDto> Handle(GetTeamDetailsQuery request, CancellationToken cancellationToken)
        {
            return await _teamService.GetTeamDetailsAsync(request.TeamId);
        }
    }

}
