using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.Certificats
{
    public class CompletedParticipantDto
    {
        public string VolunteerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public float TotalHours { get; set; }
        public DateTime ParticipationDate { get; set; }
    }

}
