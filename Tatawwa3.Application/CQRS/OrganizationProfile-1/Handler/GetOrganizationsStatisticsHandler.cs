using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.OrganizationProfile_1.Queries;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.OrganizationProfile_1.Handler
{
    public class GetOrganizationsStatisticsHandler : IRequestHandler<GetOrganizationsStatisticsQuery, OrganizationsStatisticsDTO>
    {
        private readonly IOrganizationService _organizationService;

        public GetOrganizationsStatisticsHandler(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        public async Task<OrganizationsStatisticsDTO> Handle(GetOrganizationsStatisticsQuery request, CancellationToken cancellationToken)
        {
            return await _organizationService.GetStatisticsAsync();
        }
    }
}

