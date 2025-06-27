using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.Dtos.InvitationDtos
{
    public class SentInvitationDto
    {
        public string VolunteerFullName { get; set; }
        public string VolunteerEmail { get; set; }
        public string InvitationType { get; set; }
        public string InvitationName { get; set; }
        public string SentDate { get; set; }
        public string Status { get; set; }
    }
}
