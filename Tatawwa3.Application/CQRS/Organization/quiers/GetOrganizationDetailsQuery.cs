using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.OrganizationProfile;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Organization.quiers
{
    public record GetOrganizationDetailsQuery(string OrganizationId) : IRequest<OrganizationDetailsDto?>;

    public class GetOrganizationDetailsHandler : IRequestHandler<GetOrganizationDetailsQuery, OrganizationDetailsDto?>
    {
        private readonly IOrganizationService _organizationService;

        public GetOrganizationDetailsHandler(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        public async Task<OrganizationDetailsDto?> Handle(GetOrganizationDetailsQuery request, CancellationToken cancellationToken)
        {
            return await _organizationService.GetOrganizationDetailsAsync(request.OrganizationId);
        }
    }

}
