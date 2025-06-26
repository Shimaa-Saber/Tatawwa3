using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerDashboard
{
    public class VolunteerDashboardDto
    {
        public string OpportunityTitle { get; set; }
        public string OrganizationName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; }
    }
}
