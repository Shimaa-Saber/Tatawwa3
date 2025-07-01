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
    public class GetOrganizationByNameQueryHandler: IRequestHandler<GetOrganizationByNameQuery, List<OrganizationbasedFilterationDTO>>
    {
        private readonly IOrganizationService _organizationService;
        public GetOrganizationByNameQueryHandler(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }
        public async Task<List<OrganizationbasedFilterationDTO>> Handle(GetOrganizationByNameQuery request, CancellationToken cancellationToken)
        {
            return await _organizationService.GetOrganizationByNameAsync(request.Name);

        }
    }
    //public class GetOrganizationByCityQueryHandler : IRequestHandler<GetOrganizationByCityQuery, List<OrganizationbasedFilterationDTO>>
    //{
    //    private readonly IOrganizationService _organizationService;
    //    public GetOrganizationByCityQueryHandler(IOrganizationService organizationService)
    //    {
    //        _organizationService = organizationService;
    //    }
    //    public async Task<List<OrganizationbasedFilterationDTO>> Handle(GetOrganizationByCityQuery request, CancellationToken cancellationToken)
    //    {
    //        return await _organizationService.GetOrganizationByCityAsync(request.City);

    //    }
    //}
}
