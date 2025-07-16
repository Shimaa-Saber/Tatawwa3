using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.VolunteerAttendanceAndCert
{
    public class ParticipationDto
    {
        public string OpportunityTitle { get; set; }
        public string Opportunity_discrption { get; set; }
        public DateTime Date { get; set; }
        public float Hours { get; set; }
        public string Status { get; set; }
    }

}
