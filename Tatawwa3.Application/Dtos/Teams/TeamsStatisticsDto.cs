using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.Teams
{
    public class TeamsStatisticsDto
    {
        public int TotalTeams { get; set; }
        public int ActiveTeams { get; set; }
        public int TotalMembers { get; set; }
        public int TotalOrganizations { get; set; }
    }
}
