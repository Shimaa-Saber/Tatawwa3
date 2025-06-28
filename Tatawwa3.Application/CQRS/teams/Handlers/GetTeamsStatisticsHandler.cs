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
    public class GetTeamsStatisticsHandler : IRequestHandler<GetTeamsStatisticsQuery, TeamsStatisticsDto>
    {
        private readonly IStatisticsService _statisticsService;

        public GetTeamsStatisticsHandler(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }

        public async Task<TeamsStatisticsDto> Handle(GetTeamsStatisticsQuery request, CancellationToken cancellationToken)
        {
            return await _statisticsService.GetTeamsStatisticsAsync();
        }
    }
}
