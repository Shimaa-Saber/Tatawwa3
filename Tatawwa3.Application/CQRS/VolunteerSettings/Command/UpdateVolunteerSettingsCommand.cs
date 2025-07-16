using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.VolunteerSettings;

namespace Tatawwa3.Application.CQRS.VolunteerSettings.Command
{
    public class UpdateVolunteerSettingsCommand : IRequest<bool>
    {
        public string VolunteerId { get; set; }
        public VolunteerSettingsDto Dto { get; set; }
    }
}
