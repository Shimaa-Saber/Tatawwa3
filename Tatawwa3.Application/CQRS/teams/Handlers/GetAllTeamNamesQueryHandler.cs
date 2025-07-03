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
    public class GetAllTeamNamesQueryHandler : IRequestHandler<GetAllTeamNamesQuery, List<string>>
    {
        private readonly ITeamRepository _repository;

        public GetAllTeamNamesQueryHandler(ITeamRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<string>> Handle(GetAllTeamNamesQuery request, CancellationToken cancellationToken)
        {
            return  _repository.GetAllTeamNames();
        }
    }
}
