using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.OrganizationProfile
{
    public class OrganizationDetailsDto
    {
        // 1- البيانات الشخصية
        public string Id { get; set; } = null!;
        public string OrganizationName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string City { get; set; } = null!;
        public string ProfileImage { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        // 2- الإحصائيات
        public int TotalOpportunities { get; set; }
        public int TotalTeams { get; set; }
        public int TotalCertificates { get; set; }
        public int TotalVolunteers { get; set; }

        // 3- الفرق
        public List<SimpleTeamDto> Teams { get; set; } = new();

        // 4- الفرص
        public List<SimpleOpportunityDto> Opportunities { get; set; } = new();
    }

    public class SimpleTeamDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class SimpleOpportunityDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
