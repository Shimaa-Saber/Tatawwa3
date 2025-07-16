using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.DashBord_Admin.Queries;
using Tatawwa3.Application.Dtos.AdminDashbord;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.DashBord_Admin.Handler
{
    public class GetStatisticsHandler : IRequestHandler<GetStatisticsQuery, StatisticsDto>
    {
        private readonly IUserRepository _userRepo;
        private readonly IVolunteerProfileRepository _volunteerRepo;
        private readonly IOrganizationRepository _organizationRepo;
        private readonly IVolunteerOpportunityRepository _opportunityRepo;
        private readonly IReviewRepository _reviewRepo;

        public GetStatisticsHandler(
            IUserRepository userRepo,
            IVolunteerProfileRepository volunteerRepo,
            IOrganizationRepository organizationRepo,
            IVolunteerOpportunityRepository opportunityRepo,
            IReviewRepository reviewRepo)
        {
            _userRepo = userRepo;
            _volunteerRepo = volunteerRepo;
            _organizationRepo = organizationRepo;
            _opportunityRepo = opportunityRepo;
            _reviewRepo = reviewRepo;
        }

        public async Task<StatisticsDto> Handle(GetStatisticsQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepo.CountAsync();
            var volunteers = await _userRepo.CountByRoleAsync(UserType.Volunteer);
            var organizations = await _organizationRepo.CountAsync();
            var opportunities = await _opportunityRepo.CountActiveOpportunitiesAsync();
            var totalHours = await _volunteerRepo.GetTotalHoursAsync();
            var reviews = await _reviewRepo.CountAsync();
            var certificates = await _volunteerRepo.CountCertificatesAsync(); // Assuming you have this

            return new StatisticsDto
            {
                Users = users,
                Volunteers = volunteers,
                Organizations = organizations,
                Opportunities = opportunities,
                TotalHours = (int)totalHours,
                Reviews = reviews,
                Certificates = certificates
            };
        }
    }

}
