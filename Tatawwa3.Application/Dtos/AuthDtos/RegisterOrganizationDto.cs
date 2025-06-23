using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.AuthDtos
{
    public class RegisterOrganizationDto
    {
        public string OrganizationName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public string CommercialRegistration { get; set; }
      
    }
}
