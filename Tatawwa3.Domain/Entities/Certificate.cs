using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities
{
    public class Certificate: BaseModel
    {
     

        [ForeignKey("Participation")]
        public string ParticipationID { get; set; }

        [ForeignKey("Volunteer")]
        public string VolunteerID { get; set; }
        public string? CertificateNumber { get; set; }
        public string Title { get; set; }                     
        public string Issuer { get; set; }                   
        public DateTime IssueDate { get; set; }                
        public float TotalHours { get; set; }                  
        public string ?FileUrl { get; set; }
        
       
        public bool IsVerified { get; set; }
        public string? VerificationCode { get; set; }
        public VolunteerProfile ?Volunteer { get; set; }

        public Participation ?Participation { get; set; }
    }
}
