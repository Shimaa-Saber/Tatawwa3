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
    public class GetTeamsByNameHandler : IRequestHandler<GetTeamsByNameQuery, List<GetTeamaDto>>
    {
        private readonly ITeamService _teamService;

        public GetTeamsByNameHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<List<GetTeamaDto>> Handle(GetTeamsByNameQuery request, CancellationToken cancellationToken)
        {
            return await _teamService.GetTeamsByNameAsync(request.Name);
        }
    }
}
