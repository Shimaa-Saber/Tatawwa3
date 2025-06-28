using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Tatawwa3.Application.CQRS.teams.Commands
{
    public class DeleteVolunteerTeamCommand:IRequest<Unit>
    {
        public string TeamId { get; set; }
    }
}
