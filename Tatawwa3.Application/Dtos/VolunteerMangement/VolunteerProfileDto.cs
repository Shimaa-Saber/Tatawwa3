using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerMangement
{
    public class VolunteerProfileDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public float Rating { get; set; }
        public float TotalHours { get; set; }
        public bool IsVerified { get; set; }
        public string[] Interests { get; set; }
    }

}
