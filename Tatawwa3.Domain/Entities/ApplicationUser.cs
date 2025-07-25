﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Domain.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public string ?FullName { get; set; }
        public string? NationalID { get; set; }
      
        public string City { get; set; }
        public DateTime CreatedAt { get; set; }

        public UserType Role { get; set; }

       
        public VolunteerProfile? VolunteerProfile { get; set; }
        public OrganizationProfile? OrganizationProfile { get; set; }
        public NotificationPreference ?NotificationPreference { get; set; }
      //  public ICollection<Review>?Reviews { get; set; }


    }
}
