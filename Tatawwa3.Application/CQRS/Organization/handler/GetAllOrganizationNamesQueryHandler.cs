using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.Organization.quiers;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.Organization.handler
{
    public class GetAllOrganizationNamesQueryHandler : IRequestHandler<GetAllOrganizationNamesQuery, List<string>>
    {
        private readonly IOrganizationRepository _repository;

        public GetAllOrganizationNamesQueryHandler(IOrganizationRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<string>> Handle(GetAllOrganizationNamesQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllOrganizationNamesAsync();
        }
    }
}
