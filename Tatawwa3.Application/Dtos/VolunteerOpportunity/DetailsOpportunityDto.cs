using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerOpportunity
{
    public class DetailsOpportunityDto
    {
        public string? Image { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalHours { get; set; }
        public List<string> RequiredSkills { get; set; }



        public string OrganizationName { get; set; }
        public string? OrganizationEmail { get; set; }
        public string? OrganizationPhone { get; set; }
        public string? OrganizationType { get; set; }
        public string? OrganizationImage { get; set; }
        public string? OrganizationDescription { get; set; }



        public int VolunteerCount { get; set; }
        public DateTime Deadline { get; set; }
    }
}
