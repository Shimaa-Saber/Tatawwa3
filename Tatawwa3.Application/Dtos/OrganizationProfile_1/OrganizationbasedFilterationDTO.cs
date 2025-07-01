using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.OrganizationProfile_1
{
    public class OrganizationbasedFilterationDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string OrganizationType { get; set; }
        public string Status { get; set; }
        public int OpportunitiesCount { get; set; }
        public string Email { get; set; }

    }
}
