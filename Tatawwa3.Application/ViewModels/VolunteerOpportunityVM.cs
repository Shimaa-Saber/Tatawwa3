using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.ViewModels
{
    public class VolunteerOpportunityVM
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public string CategoryName { get; set; }
        public string OrganizationName { get; set; }
    }
}
