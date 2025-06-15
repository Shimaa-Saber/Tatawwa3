using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities
{
    public class OrganizationProfile
    {
        public string ID { get; set; }
        [ForeignKey("User")]
        public string UserID { get; set; }
        public string OrganizationName { get; set; }
        public string CommercialRegistration { get; set; }
      
        public bool IsVerified { get; set; }

        public ApplicationUser? User { get; set; }
        public ICollection<Team> ?Teams { get; set; }
        public ICollection<VolunteerOpportunity>? VolunteerOpportunities { get; set; }
    }
}
