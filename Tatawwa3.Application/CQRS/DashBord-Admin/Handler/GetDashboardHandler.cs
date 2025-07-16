using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.DashBord_Admin.Queries;
using Tatawwa3.Application.Dtos.AdminDashbord;
using Tatawwa3.Application.Services;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.DashBord_Admin.Handler
{
    public class GetDashboardHandler : IRequestHandler<GetDashboardQuery, DashboardDto>
    {
        private readonly IUserRepository _userRepo;
        private readonly IVolunteerProfileRepository _volunteerRepo;
        private readonly IVolunteerOpportunityRepository _opportunityRepo;
        private readonly IOrganizationRepository _orgRepo;

        public GetDashboardHandler(
            IUserRepository userRepo,
            IVolunteerProfileRepository volunteerRepo,
            IVolunteerOpportunityRepository opportunityRepo,
            IOrganizationRepository orgRepo)
        {
            _userRepo = userRepo;
            _volunteerRepo = volunteerRepo;
            _opportunityRepo = opportunityRepo;
            _orgRepo = orgRepo;
        }
        public async Task<DashboardDto> Handle(GetDashboardQuery request, CancellationToken cancellationToken)
        {
            var volunteerCount = await _userRepo.CountByRoleAsync(UserType.Volunteer);
            var organizationCount = await _orgRepo.CountAsync();
            var opportunityCount = await _opportunityRepo.CountActiveOpportunitiesAsync();
            var totalHours = await _volunteerRepo.GetTotalHoursAsync();

            var growthData = await _userRepo.GetUserGrowthByMonthAsync();


            

            var userGrowth = growthData.Select(g => new UserGrowthDto
            {
                Month = $"{g.Year}-{g.Month:D2}",
                Count = g.Count
            }).ToList();

            return new DashboardDto
            {
                TotalVolunteers = volunteerCount,
                TotalOrganizations = organizationCount,
                ActiveOpportunities = opportunityCount,
                TotalHours = totalHours,
                MonthlyUserGrowth = userGrowth,
                ActivityDistribution = new ActivityDistributionDto
                {
                    Volunteers = volunteerCount,
                    Organizations = organizationCount,
                    Opportunities = opportunityCount
                }
            };
        }
    }
}
