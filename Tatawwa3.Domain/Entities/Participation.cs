using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Domain.Entities
{
    public class Participation : BaseModel
    {
  
        public string ApplicationID { get; set; }

        [ForeignKey("Opportunity")]
        public string? OpportunityId { get; set; }
        public float TotalAttendedHours { get; set; }
        public DateTime FirstCheckIn { get; set; }
        public DateTime LastCheckOut { get; set; }
        public ParticipationStatus Status { get; set; }
        [ForeignKey("Volunteer")]
        public string ?VolunteerID { get; set; }

        public Application? Application { get; set; }
        public VolunteerProfile? Volunteer { get; set; }
        public ICollection<Attendance> ?Attendances { get; set; }
        public VolunteerOpportunity? Opportunity { get; set; }
        public Certificate? Certificate { get; set; }
    }
}
