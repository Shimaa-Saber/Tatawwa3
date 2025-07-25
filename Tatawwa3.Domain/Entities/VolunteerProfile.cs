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
    public class VolunteerProfile: BaseModel
    {
    
        [ForeignKey("User")]
        
        public string UserID { get; set; }
        public VolunteerStatus Status { get; set; }
        public bool IsBanned { get; set; }
        public string? Skills { get; set; } 
        public string Interests { get; set; } 
        public float TotalHours { get; set; }
        public float Rating { get; set; }
        public bool IsVerified { get; set; }
        public string? ProfilePictureUrl { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public ApplicationUser? User { get; set; }
      
        public ICollection<TeamMember>? TeamsMemberships { get; set; }
        public ICollection<Participation> ?Participations { get; set; }
        public ICollection<Certificate>? Certificates { get; set; }


    }
}
