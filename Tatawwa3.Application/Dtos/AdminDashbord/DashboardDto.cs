using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.AdminDashbord
{
   public class DashboardDto
    {
        public int TotalUsers { get; set; }
        public int TotalVolunteers { get; set; }
        public int TotalOrganizations { get; set; }
        public int ActiveOpportunities { get; set; }
        public float TotalHours { get; set; }

        public List<UserGrowthDto> MonthlyUserGrowth { get; set; }
        public ActivityDistributionDto ActivityDistribution { get; set; }
    }
}
