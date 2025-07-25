﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;



namespace Tatawwa3.Domain.Entities
{
    public class OrganizationProfile: BaseModel
    {
        public OrganizationStatus Status { get; set; } = OrganizationStatus.Pending;

        [ForeignKey("User")]
        public string UserID { get; set; }
        public string OrganizationName { get; set; }
        public string CommercialRegistration { get; set; }

        public string? Description { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ProfileImage { get; set; }
        public string? Email { get; set; }

        public string? ProfilePictureUrl { get; set; }

        public string City { get; set; }




        public string? WebsiteUrl { get; set; }

        public OrganizationTypeEnum OrganizationType { get; set; }
        public bool IsDeactivationRequested { get; set; } = false;



        public bool IsBanned { get; set; } = false;
        public bool IsVerified { get; set; }

        public ApplicationUser? User { get; set; }
        public ICollection<Team> ?Teams { get; set; }
        public ICollection<VolunteerOpportunity>? VolunteerOpportunities { get; set; }
    }
}
