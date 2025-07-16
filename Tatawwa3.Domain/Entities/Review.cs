using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities
{
    public class Review:BaseModel
    {
        [ForeignKey("VolunteerOpportunity")]
        public string OpportunityId { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; } 
        public string? Comment { get; set; } 
        public DateTime CreatedAt { get; set; }

        public VolunteerOpportunity? Opportunity { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser ?User { get; set; }



    }
}
