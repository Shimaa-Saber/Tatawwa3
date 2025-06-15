using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Domain.Entities
{
    public class Attendance
    {
        public string ID { get; set; }

        [ForeignKey("Participation")]
        public string ParticipationID { get; set; }
        public DateTime AttendanceDate { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan CheckOutTime { get; set; }
        public float HoursWorked { get; set; }
        public AttendanceStatus Status { get; set; }

        public Participation? Participation { get; set; }
    }
}
