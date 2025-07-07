using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    internal class GetTeamNamesByOrganizationIdHandler : IRequestHandler<GetTeamNamesByOrganizationIdQuery, List<string>>
    {
        private readonly ITeamRepository _teamRepo;

        public GetTeamNamesByOrganizationIdHandler(ITeamRepository teamRepo)
        {
            _teamRepo = teamRepo;
        }
        public Task<List<string>> Handle(GetTeamNamesByOrganizationIdQuery request, CancellationToken cancellationToken)
        {
            var teamNames = _teamRepo.GetTeamNamesByOrganizationId(request.orgId);
            return Task.FromResult(teamNames);
        }
    }
}
