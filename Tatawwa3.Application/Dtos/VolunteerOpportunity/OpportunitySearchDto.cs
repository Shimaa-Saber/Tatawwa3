using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerOpportunity
{
    public class OpportunitySearchDto
    {
        public string? Status { get; set; }
        public string? OrganizationName { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
