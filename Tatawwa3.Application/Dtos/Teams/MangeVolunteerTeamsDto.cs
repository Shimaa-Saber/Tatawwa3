using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.Teams
{
    public class MangeVolunteerTeamsDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }        // ← وصف الفريق
        public DateTime CreationDate { get; set; }
        public TeamStatus Status { get; set; }
        public string OrganizationName { get; set; }
        public int ActualMembersCount { get; set; }
    }
}
