using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.teams.Commands;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class DeleteVolunteerTeamCommandHandler : IRequestHandler<DeleteVolunteerTeamCommand, Unit>
    {
        private readonly ITeamService _contextservice;

        public DeleteVolunteerTeamCommandHandler(ITeamService context)
        {
            _contextservice = context;
        }

        public async Task<Unit> Handle(DeleteVolunteerTeamCommand request, CancellationToken cancellationToken)
        {
             await _contextservice.DEleteVolunteerTeamAsync(request.TeamId);
            return Unit.Value;
        }
    }
}
