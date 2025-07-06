using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.OrganizationProfile
{
    public class DashboardStatisticsDTO
    {
        public int GrantedCertificatesCount { get; set; }
        public double TotalVolunteeringHours { get; set; }
        public int ActiveOpportunitiesCount { get; set; }
        public int VolunteersCount { get; set; }
    }
}
