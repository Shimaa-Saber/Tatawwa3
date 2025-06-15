using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities
{
    public class VolunteerAchievement
    {
        public string ID { get; set; }

        [ForeignKey("VolunteerProfile")]
        public string VolunteerID { get; set; }
        [ForeignKey("Achievement")]
        public string AchievementID { get; set; }
        public DateTime EarnedDate { get; set; }
        public bool IsNotified { get; set; }

        public VolunteerProfile? Volunteer { get; set; }
        public Achievement? Achievement { get; set; }
    }
}
