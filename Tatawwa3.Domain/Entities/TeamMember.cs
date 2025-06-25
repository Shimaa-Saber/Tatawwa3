using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities
{
    public class TeamMember: BaseModel
    {
      
        [ForeignKey("Team")]
        public string TeamID { get; set; }

        [ForeignKey("VolunteerProfile")]
        public string VolunteerID { get; set; }

       
        public DateTime JoinDate { get; set; }

      

        public Team? Team { get; set; }
        public string?  Role {  get; set; }


        public VolunteerProfile? Volunteer { get; set; }
    }
}
