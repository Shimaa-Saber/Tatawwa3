using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.OrganizationProfile_1
{
    public class OrganizationsStatisticsDTO
    {
        public int TotalOrganizations { get; set; }
        public int ActiveOrganizations { get; set; }
        public int PendingOrganizations { get; set; }
        public int RejectedOrganizations { get; set; }
    }
}
