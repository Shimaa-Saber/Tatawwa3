using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.Dtos.OrganizationProfile;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Infrastructure.Data;
using Tatawwa3.Infrastructure.Repositorirs;
using Tatawwa3.Domain.Enums;
namespace Tatawwa3.Application.Services
{
    public class DashboardStatisticsService : IDashboardStatisticsService
    {
        private readonly Tatawwa3DbContext _Context;

        public DashboardStatisticsService(Tatawwa3DbContext Context)
        {
            _Context = Context;
        }

        public async Task<DashboardStatisticsDTO> GetStatisticsAsync()
        {
            var grantedCertificates= await _Context.Certificates.CountAsync();
            var totalHours = await _Context.Achievements.Where(a => a.RequiredHours != null)
            .SumAsync(a => a.RequiredHours);
            var activeOpportunities = await _Context.VolunteerOpportunities.Where(o => o.Status == OpportunityStatus.Completed).CountAsync();
            var volunteers=await _Context.VolunteerProfiles.CountAsync();

            return new DashboardStatisticsDTO
            {
                GrantedCertificatesCount = grantedCertificates,
                TotalVolunteeringHours = totalHours,
                ActiveOpportunitiesCount = activeOpportunities,
                VolunteersCount = volunteers
            };


        }
    }
    }
