using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.CQRS.teams.Commands
{
    public class RespondToJoinRequestCommand : IRequest<string>
    {
        public string TeamId { get; set; }
        public string VolunteerId { get; set; }
        public bool IsAccepted { get; set; }

        public RespondToJoinRequestCommand(string teamId, string volunteerId, bool isAccepted)
        {
            TeamId = teamId;
            VolunteerId = volunteerId;
            IsAccepted = isAccepted;
        }
    }
}
