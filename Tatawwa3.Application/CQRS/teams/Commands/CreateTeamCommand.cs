using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.Application.CQRS.Team.Commands
{
    public class CreateTeamCommand: IRequest<Unit>
    {
        public CreateTeamDto Dto { get; }

        public CreateTeamCommand(CreateTeamDto dto)
        {
            Dto = dto;
        }
    }
}
