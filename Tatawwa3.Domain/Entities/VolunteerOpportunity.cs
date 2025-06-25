using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;
using static System.Net.Mime.MediaTypeNames;

namespace Tatawwa3.Domain.Entities
{
    public class VolunteerOpportunity: BaseModel
    {
    
        [ForeignKey("Organization")]
        public string OrganizationID { get; set; }
        [ForeignKey("Category")]
        public string CategoryID { get; set; }
        [ForeignKey("Team")]
        public string? TeamId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RequiredVolunteers { get; set; }
        public OpportunityStatus Status { get; set; }
        public string? Image { get; set; }

        public OrganizationProfile? Organization { get; set; }
        public Category? Category { get; set; }
        public Team ?Team { get; set; }
        public ICollection<Application> ?Applications { get; set; }

    }
}
