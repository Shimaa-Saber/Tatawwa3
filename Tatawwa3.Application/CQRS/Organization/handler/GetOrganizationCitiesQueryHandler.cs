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
    public class GetOrganizationCitiesQueryHandler : IRequestHandler<GetAllCitiesQuery, List<string>>
    {
        private readonly IOrganizationRepository _organizationRepository;

        public GetOrganizationCitiesQueryHandler(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

        public async Task<List<string>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
        {
            return await _organizationRepository.GetAllCitiesAsync();
        }
    }
}
