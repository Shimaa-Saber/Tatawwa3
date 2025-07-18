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
    public class RespondToJoinRequestByIdgdedHandler : IRequestHandler<RespondToJoinRequestByIdgdedCommand, string>
    {
        private readonly ITeamService _teamService;

        public RespondToJoinRequestByIdgdedHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<string> Handle(RespondToJoinRequestByIdgdedCommand request, CancellationToken cancellationToken)
        {
            return await _teamService.RespondToJoinRequesgdedtByIdAsync(request.JoinRequestId, request.IsAccepted);
        }
    }
}
