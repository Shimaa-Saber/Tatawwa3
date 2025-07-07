using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerMangement;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerMangement.Queries
{
    public class GetAllApplicationsQuery : IRequest<List<ApplicationDto>>
    {
        public string OrgUserId { get; }
        public GetAllApplicationsQuery(string orgUserId)
        {
            OrgUserId = orgUserId;
        }
    }


    public class GetAllApplicationsHandler : IRequestHandler<GetAllApplicationsQuery, List<ApplicationDto>>
    {
        private readonly IApplicationService _applicationService;

        public GetAllApplicationsHandler(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public async Task<List<ApplicationDto>> Handle(GetAllApplicationsQuery request, CancellationToken cancellationToken)
        {
            return await _applicationService.GetAllApplicationsByOrganizationAsync(request.OrgUserId);
        }
    }

}
