using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.Application.CQRS.teams.Commands
{
    public class UpdateTeamCommand : IRequest<Unit>
    {
        public string TeamId { get; set; }
        public UpdateTeamDto Dto { get; set; }
    }
}
