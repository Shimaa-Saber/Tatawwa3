using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Domain.Entities
{
    public class Application: BaseModel
    {
       
        [ForeignKey("Opportunity")]
        public string OpportunityID { get; set; }
        [ForeignKey("VolunteerProfile")]
        public string VolunteerID { get; set; }
        public ApplicationStatus Status { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string MotivationLetter { get; set; }

        public VolunteerOpportunity? Opportunity { get; set; }
        public VolunteerProfile? Volunteer { get; set; }
        public Participation? Participation { get; set; }
    }
}
