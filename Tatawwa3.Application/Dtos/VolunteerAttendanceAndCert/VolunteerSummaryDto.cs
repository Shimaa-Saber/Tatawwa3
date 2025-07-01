using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerAttendanceAndCert
{
    public class VolunteerSummaryDto
    {
        public int TotalOpportunities { get; set; }
        public float TotalHours { get; set; }
        public int TotalCertificates { get; set; }
    }

}
