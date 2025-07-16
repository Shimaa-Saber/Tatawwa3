using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.Attendace
{
    public class UpdateAttendanceDto
    {
        public string ParticipationId { get; set; }
        public AttendanceStatus AttendanceStatus { get; set; }
        public float ApprovedHours { get; set; }
        public string? Comment { get; set; }
    }

}
