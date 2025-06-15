using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Domain.Entities
{
    public class Participation
    {
        public string ID { get; set; }
        public string ApplicationID { get; set; }
        public float TotalAttendedHours { get; set; }
        public DateTime FirstCheckIn { get; set; }
        public DateTime LastCheckOut { get; set; }
        public ParticipationStatus Status { get; set; }

        public Application? Application { get; set; }
        public ICollection<Attendance> ?Attendances { get; set; }
        public Certificate? Certificate { get; set; }
    }
}
