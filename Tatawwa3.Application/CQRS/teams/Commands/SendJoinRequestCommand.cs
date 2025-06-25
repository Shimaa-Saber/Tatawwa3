using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.Application.CQRS.teams.Commands
{
    public class SendJoinRequestCommand:IRequest
    {
        public JoinRequestDto Dto { get; set; }
        public string VolunteerId { get; set; }

        public SendJoinRequestCommand(JoinRequestDto dto, string volunteerId)
        {
            Dto = dto;
            VolunteerId = volunteerId;
        }

    }
}
