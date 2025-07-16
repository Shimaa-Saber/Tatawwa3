using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tatawwa3.Application.Dtos.Teams;
using MediatR;
namespace Tatawwa3.Application.CQRS.teams.Commands
{
    public class UpdateTeamPageCommand : IRequest<Unit>
    {
        public UpdateTeamPageDto Dto { get; set; }

        public UpdateTeamPageCommand(UpdateTeamPageDto dto)
        {
            Dto = dto;
        }
    }
}
