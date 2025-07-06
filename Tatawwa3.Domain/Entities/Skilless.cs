using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities
{
    public class Skilless:BaseModel
    {
       // public string Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Opportunity")]
        public string OpportunityID { get; set; }
        public VolunteerOpportunity Opportunity { get; set; }
    }
}
