using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class GetTeamsByCityHandler : IRequestHandler<GetTeamsByCityQuery, List<GetTeamaDto>>
    {
        private readonly ITeamService _teamService;

        public GetTeamsByCityHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<List<GetTeamaDto>> Handle(GetTeamsByCityQuery request, CancellationToken cancellationToken)
        {
            return await _teamService.GetTeamsByCityAsync(request.City);
        }
    }
}
