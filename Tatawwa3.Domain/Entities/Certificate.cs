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
        public string CertificateNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public float TotalHours { get; set; }
        public bool IsVerified { get; set; }
        public string VerificationCode { get; set; }

        public Participation ?Participation { get; set; }
    }
}
