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
    public class GetTeamsByCategoryHandler : IRequestHandler<GetTeamsByCategoryQuery, List<GetTeamaDto>>
    {
        private readonly ITeamService _teamService;

        public GetTeamsByCategoryHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<List<GetTeamaDto>> Handle(GetTeamsByCategoryQuery request, CancellationToken cancellationToken)
        {
            return await _teamService.GetTeamsByCategoryAsync(request.CategoryName);
        }
    }
}
