using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.Teams
{
    public class TeamDetailsDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TeamStatus Status { get; set; }
        public DateTime CreationDate { get; set; }
        public string City { get; set; }
        public string CategoryName { get; set; }
        public string OrganizationName { get; set; }

        public List<MemberDto> Members { get; set; }
        public List<OpportunityDto> Opportunities { get; set; }

        public int TotalMembers { get; set; }
        public int TotalProjects { get; set; }
        public int AvailableOpportunities { get; set; }
        public double CompletionRate { get; set; }
    }
}
