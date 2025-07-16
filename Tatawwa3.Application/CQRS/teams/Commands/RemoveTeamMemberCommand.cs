using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Tatawwa3.Application.CQRS.teams.Commands
{
    public class RemoveTeamMemberCommand : IRequest<bool>
    {
        public string TeamId { get; set; }
        public string VolunteerId { get; set; }

        public RemoveTeamMemberCommand(string teamId, string volunteerId)
        {
            TeamId = teamId;
            VolunteerId = volunteerId;
        }
    }
}
