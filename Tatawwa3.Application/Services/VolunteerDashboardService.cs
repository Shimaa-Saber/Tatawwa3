//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using AutoMapper;
//using Tatawwa3.Application.Dtos.VolunteerDashboard;
//using Tatawwa3.Application.Interfaces;
//using Tatawwa3.Domain.Interfaces;
//using Microsoft.EntityFrameworkCore;
//namespace Tatawwa3.Application.Services
//{
//    public class VolunteerDashboardService : IDashboardVolunteer
//    {
//        private readonly IMapper _mapper;
//        private readonly IApplicationRepository _repository;
//        public VolunteerDashboardService(IApplicationRepository repository, IMapper mapper)
//        {
//            _repository = repository;
//            _mapper = mapper;
//        }
//        public async Task<List<VolunteerDashboardDto>> GetDashboardDataAsync(string volunteerId)
//        {
//            var applications = _repository
//                .GetApplicationsByVolunteerId(volunteerId)
//                .Select(a => new VolunteerDashboardDto
//                {
//                    OpportunityTitle = a.Opportunity.Title,
//                    OrganizationName = a.Opportunity.Organization.OrganizationName,
//                    ApplicationDate = a.ApplicationDate,
//                    Status = a.Status.ToString()
//                });

//            return await applications.ToListAsync();
//        }
//    }
//}
