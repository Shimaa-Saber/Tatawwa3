using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.Notifications
{
    public class UpdateOrgNotificationPreferencesDto
    {
        public bool NotifyOnNewVolunteerApplication { get; set; }
        public bool NotifyOnVolunteerApplicationUnderReview { get; set; }
        public bool NotifyOnOpportunityCompleted { get; set; }
    }

}
