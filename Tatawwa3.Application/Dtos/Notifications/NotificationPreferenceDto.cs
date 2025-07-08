using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.Notifications
{
    public class NotificationPreferenceDto
    {
        public bool NotifyOnApplicationAccepted { get; set; }
        public bool NotifyOnCertificateIssued { get; set; }
        public bool NotifyOnOpportunityRecommendations { get; set; }
    }

}
