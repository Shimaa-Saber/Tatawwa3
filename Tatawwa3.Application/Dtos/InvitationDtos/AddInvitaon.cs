using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Dtos.InvitationDtos
{
   public class AddInvitaon
    {
        public string VolunteerFullName { get; set; }

        public InvitationType InvitationType { get; set; }

        public string? TeamName { get; set; }
        public string? OpportunityTitle { get; set; }

        public string PersonalMessage { get; set; }
    }
}
