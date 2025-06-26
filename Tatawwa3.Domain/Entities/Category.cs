using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities
{
    public class Category: BaseModel
    {
    
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

        public ICollection<VolunteerOpportunity>? Opportunities { get; set; }
        public ICollection<VolunteerProfile> VolunteerProfiles { get; set; }
    }
}
