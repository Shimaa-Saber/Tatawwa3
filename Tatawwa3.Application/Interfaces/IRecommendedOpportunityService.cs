using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerDashboard;

namespace Tatawwa3.Application.Interfaces
{
    public interface IRecommendedOpportunityService
    {
        Task<List<RecommendedOpportunityDto>> GetRecommendedOpportunitiesAsync(string volunteerId);
    }
}
