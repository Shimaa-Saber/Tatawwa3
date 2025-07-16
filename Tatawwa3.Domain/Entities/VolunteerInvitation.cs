using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Domain.Enums;
namespace Tatawwa3.Domain.Entities
{
    public class VolunteerInvitation:BaseModel
    {
        [ForeignKey("Volunteer")]
        public string VolunteerId { get; set; }
        public VolunteerProfile? Volunteer { get; set; }

       
        public InvitationType? InvitationType { get; set; }

      
        [ForeignKey("Opportunity")]
        public string? OpportunityId { get; set; }
        public VolunteerOpportunity? Opportunity { get; set; }

     
        [ForeignKey("Team")]
        public string? TeamId { get; set; }
        public Team? Team { get; set; }

       
        public string PersonalMessage { get; set; }

       
        public InvitationStatus? Status { get; set; } = InvitationStatus.Pending;

       
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
    }
}
