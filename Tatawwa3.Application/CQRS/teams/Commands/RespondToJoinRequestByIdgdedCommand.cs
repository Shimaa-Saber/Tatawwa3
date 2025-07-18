using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.CQRS.teams.Commands
{
    public class RespondToJoinRequestByIdgdedCommand : IRequest<string>
    {
        public string JoinRequestId { get; set; }
        public bool IsAccepted { get; set; }
    }
    
}
