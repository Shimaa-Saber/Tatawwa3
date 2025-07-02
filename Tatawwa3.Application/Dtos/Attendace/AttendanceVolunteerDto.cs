using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.Attendace
{
    public class AttendanceVolunteerDto
    {
        public string VolunteerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ParticipationId { get; set; }
        public string AttendanceStatus { get; set; } 
        public float ApprovedHours { get; set; }
        public string? Comment { get; set; }
    }

}
