using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerMangement
{
    public class VolunteerProfileDetailsDto
    {
        // 1- معلومات شخصية
        public string Id { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? City { get; set; }
        public string? ProfileImage { get; set; }
        public DateTime JoinedAt { get; set; }

        // 2- إحصائيات
        public int TotalJoinedTeams { get; set; }
        public int TotalCertificates { get; set; }
        public int TotalOpportunities { get; set; }

        // 3- فرص التطوع اللي هو مقبول فيها
        public List<VolunteerOpportunityDto> Opportunities { get; set; } = new();

        // 4- الشهادات
        public List<VolunteerCertificateDto> Certificates { get; set; } = new();

        // 5- الفرق
        public List<VolunteerTeamDto> Teams { get; set; } = new();
    }

    public class VolunteerOpportunityDto
    {
        public string Title { get; set; }
        public DateTime JoinedAt { get; set; }
    }

    public class VolunteerCertificateDto
    {
        public string Title { get; set; }
        public DateTime IssueDate { get; set; }
    }

    public class VolunteerTeamDto
    {
        public string TeamName { get; set; }
        public string Role { get; set; }
    }

}
