using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.AdminVolunteer
{
    public class AdminVolunteerManagementDTO
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public DateTime JoinDate { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public int OpportunitiesAppliedCount { get; set; }
        public int TeamsJoinedCount { get; set; }
        public double VolunteerHours { get; set; }
        public bool IsBanned { get; set; }
    }
}
