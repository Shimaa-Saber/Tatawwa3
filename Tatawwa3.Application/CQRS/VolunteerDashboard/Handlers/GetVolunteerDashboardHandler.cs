using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.VolunteerDashboard.Queries;
using Tatawwa3.Application.Dtos.VolunteerDashboard;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Application.Services;

namespace Tatawwa3.Application.CQRS.VolunteerDashboard.Handlers
{

    public class GetVolunteerDashboardHandler : IRequestHandler<GetVolunteerDashboardQuery, List<VolunteerDashboardDto>>
    {
        private readonly IDashboardVolunteer _dashboardService;

        public GetVolunteerDashboardHandler(IDashboardVolunteer dashboardService)
        {
            _dashboardService = dashboardService;
        }

        public async Task<List<VolunteerDashboardDto>> Handle(GetVolunteerDashboardQuery request, CancellationToken cancellationToken)
        {
            return await _dashboardService.GetDashboardDataAsync(request.UserId);
        }
    }
}
