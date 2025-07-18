using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.Teams
{
    public class CreateTeamDto
    {
        public string  Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? CategoryId { get; set; }
        public string City { get; set; }
        public bool IsLinkedToOpportunity { get; set; }
        public TeamJoinPermission JoinPermission { get; set; }
        public int? MaxMembers { get; set; }
        public string? InternalNotes { get; set; }
        public string? OrganizationID { get; set; }
        public string? CategoryName { get; set; }          // ✅ بدل الـ ID
        public string? OpportunityTitle { get; set; }      // ✅ اسم الفرصة
    }
}
