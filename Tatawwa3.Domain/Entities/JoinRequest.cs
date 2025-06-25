using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Domain.Entities
{
    public class JoinRequest:BaseModel
    {
       
        [ForeignKey("Team")]
        public string TeamId { get; set; }
        public Team ?Team { get; set; }

        [ForeignKey("VolunteerProfile")]
        public string VolunteerId { get; set; }
        public VolunteerProfile? Volunteer { get; set; }

        public string Motivation { get; set; }
        public bool HasPreviousExperience { get; set; }
        public string Skills { get; set; } 
        public RequestStatus Status { get; set; } = RequestStatus.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
