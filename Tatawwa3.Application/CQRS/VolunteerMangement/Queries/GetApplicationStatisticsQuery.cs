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
    public class GetApplicationStatisticsQuery : IRequest<ApplicationStatisticsDto> { 
    public string OppId { get; }
        public GetApplicationStatisticsQuery(string oppId)
        {
            OppId = oppId;
        }

    }

    public class GetApplicationStatisticsHandler : IRequestHandler<GetApplicationStatisticsQuery, ApplicationStatisticsDto>
    {
        private readonly IApplicationService _applicationService;

        public GetApplicationStatisticsHandler(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public async Task<ApplicationStatisticsDto> Handle(GetApplicationStatisticsQuery request, CancellationToken cancellationToken)
        {
            return await _applicationService.GetApplicationStatisticsAsync(request.OppId);
        }
    }

}
