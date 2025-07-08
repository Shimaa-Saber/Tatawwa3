using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities
{
    public class NotificationPreference : BaseModel
    {
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public bool NotifyOnApplicationAccepted { get; set; } = true;
        public bool NotifyOnCertificateIssued { get; set; } = true;
        public bool NotifyOnOpportunityRecommendations { get; set; } = false;

        public bool NotifyOnNewVolunteerApplication { get; set; } = true;
        public bool NotifyOnVolunteerApplicationUnderReview { get; set; } = true;
        public bool NotifyOnOpportunityCompleted { get; set; } = true;
    }

}
