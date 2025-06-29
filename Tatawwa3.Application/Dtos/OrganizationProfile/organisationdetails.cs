using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.OrganizationProfile
{
    public class organisationdetails
    {
        public string Id { get; set; }
        public string OrganizationName { get; set; }
        public string CommercialRegistration { get; set; }
        public string OrganizationType { get; set; }  
        public bool IsVerified { get; set; }

      
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
