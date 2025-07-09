using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.VolunteerDashboard
{
    public class RecommendedOpportunityDto
    {
        public string OpportunityTitle { get; set; }
        public string OrganizationName { get; set; }
        public string Category { get; set; }
        public DateTime StartDate { get; set; }
        public string id { get; set; }
        public string Location { get; set; }
        public string? Image { get; set; }
    }
}
