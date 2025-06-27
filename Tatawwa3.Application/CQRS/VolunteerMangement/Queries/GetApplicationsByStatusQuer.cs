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
    public class GetApplicationsByStatusQuery : IRequest<List<ApplicationDto>>
    {
        public string Status { get; set; }

        public GetApplicationsByStatusQuery(string status)
        {
            Status = status;
        }
    }

    public class GetApplicationsByStatusHandler : IRequestHandler<GetApplicationsByStatusQuery, List<ApplicationDto>>
    {
        private readonly IApplicationService _applicationService;

        public GetApplicationsByStatusHandler(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public async Task<List<ApplicationDto>> Handle(GetApplicationsByStatusQuery request, CancellationToken cancellationToken)
        {
            return await _applicationService.GetApplicationsByStatusAsync(request.Status);
        }
    }

}
