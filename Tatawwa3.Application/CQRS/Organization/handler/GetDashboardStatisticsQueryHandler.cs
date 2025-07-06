using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.Organization.quiers;
using Tatawwa3.Application.Dtos.OrganizationProfile;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Organization.handler
{
    public class GetDashboardStatisticsQueryHandler : IRequestHandler<GetDashboardStatisticsQuery,DashboardStatisticsDTO>
    {
        private readonly IDashboardStatisticsService _dashboardStatisticsService;
        public GetDashboardStatisticsQueryHandler(IDashboardStatisticsService dashboardStatisticsService)
        {
            _dashboardStatisticsService = dashboardStatisticsService;
        }

        public async Task<DashboardStatisticsDTO> Handle(GetDashboardStatisticsQuery request, CancellationToken cancellationToken)
        {
            return await _dashboardStatisticsService.GetStatisticsAsync();
        }
    }
}
