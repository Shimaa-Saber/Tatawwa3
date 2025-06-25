using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.teams.Commands;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class SendJoinRequestHandler : IRequestHandler<SendJoinRequestCommand>
    {
        private readonly ITeamService _joinRequestService;

        public SendJoinRequestHandler(ITeamService joinRequestService)
        {
            _joinRequestService = joinRequestService;
        }

        public async Task Handle(SendJoinRequestCommand request, CancellationToken cancellationToken)
        {
            await _joinRequestService.SendJoinRequestAsync(request.Dto, request.VolunteerId);
        }
    }
}
