using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos;

namespace Tatawwa3.Application.Dtos
{
    public class TeamMemberDto
    {
        public string VolunteerId { get; set; }
        public string Name { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Role { get; set; }
    }
}
