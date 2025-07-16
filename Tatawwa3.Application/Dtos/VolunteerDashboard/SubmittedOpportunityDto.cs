using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.VolunteerDashboard
{
    public class SubmittedOpportunityDto
    {
        public string OpportunityTitle { get; set; }
        public string OrganizationName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public ApplicationStatus Status { get; set; }
    }
}
