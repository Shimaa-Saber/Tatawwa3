using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerOpportunity
{
    public  class GetAllOpportunitiesDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string OrganizationName { get; set; }
        public string CategoryName { get; set; }
    }
}
