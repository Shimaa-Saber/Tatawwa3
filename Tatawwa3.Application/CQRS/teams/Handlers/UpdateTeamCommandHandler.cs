using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.teams.Commands;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class UpdateTeamCommandHandler : IRequestHandler<UpdateTeamCommand, Unit>
    {
        private readonly ITeamService _teamService;

        public UpdateTeamCommandHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<Unit> Handle(UpdateTeamCommand request, CancellationToken cancellationToken)
        {
            await _teamService.UpdateTeamAsync(request.Dto, request.TeamId);
            return Unit.Value;
        }
    }
}
