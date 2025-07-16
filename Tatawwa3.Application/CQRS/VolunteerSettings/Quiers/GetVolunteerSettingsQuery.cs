using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.VolunteerSettings;

namespace Tatawwa3.Application.CQRS.VolunteerSettings.Quiers
{
    public class GetVolunteerSettingsQuery : IRequest<VolunteerSettingsDto>
    {
        public string VolunteerId { get; set; }
    }
}
