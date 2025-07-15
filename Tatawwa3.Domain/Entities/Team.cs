using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

   
        public string Id { get; set; }
        [ForeignKey("Organization")]
        public string? OrganizationID { get; set; }
        [ForeignKey("Category")]
        public string? CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TeamStatus Status { get; set; }
        public DateTime CreationDate { get; set; }

        public string? TeamGoals { get; set; }
        public string? City { get; set; }
        public bool? IsLinkedToOpportunity { get; set; }
        public int? MaxMembers { get; set; }
        public string? InternalNotes { get; set; }
        public OrganizationProfile? Organization { get; set; }
        public ICollection<TeamMember> ?Members { get; set; }
        public ICollection<VolunteerOpportunity>? Opportunities { get; set; }

        public string? OpportunityId { get; set; }
        public Category? Category { get; set; }

        public TeamJoinPermission? JoinPermission { get; set; }
    }
}
