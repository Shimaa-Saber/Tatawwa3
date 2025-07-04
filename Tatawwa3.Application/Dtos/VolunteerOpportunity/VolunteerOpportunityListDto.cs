using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.VolunteerOpportunity
{
    public class VolunteerOpportunityListDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string OrganizationName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public OpportunityStatus Status { get; set; }
        public string StatusDisplay { get; set; }
        public int ApplicantsCount { get; set; }
        public double AverageRating { get; set; }
    }
}
