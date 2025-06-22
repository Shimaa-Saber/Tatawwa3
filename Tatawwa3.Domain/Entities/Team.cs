using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Domain.Entities
{
    public class Team: BaseModel
    {

        [ForeignKey("OrganizationProfile")]
        public string OrganizationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TeamStatus Status { get; set; }
        public DateTime CreationDate { get; set; }

        public OrganizationProfile? Organization { get; set; }
        public ICollection<TeamMember> ?Members { get; set; }
    }
}
