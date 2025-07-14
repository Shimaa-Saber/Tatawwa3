using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.OrganizationProfile
{
    public class UpdateOrganizationDto
    {

        public string Id { get; set; }
        public string OrganizationName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        //public OrganizationTypeEnum OrganizationType { get; set; }
        public string City { get; set; }
       
        public IFormFile? LogoFile { get; set; }
    }
}
