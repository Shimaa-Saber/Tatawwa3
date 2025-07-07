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
    public class GetApplicationsByDateQuery : IRequest<List<ApplicationDto>>
    {

        public string OpportunityId { get; set; }
        public DateTime Date { get; set; }


        public GetApplicationsByDateQuery(DateTime date, string opportunityId)
        {
            Date = date;
            OpportunityId = opportunityId;
        }
    }


    public class GetApplicationsByDateHandler : IRequestHandler<GetApplicationsByDateQuery, List<ApplicationDto>>
    {
        private readonly IApplicationService _applicationService;

        public GetApplicationsByDateHandler(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public async Task<List<ApplicationDto>> Handle(GetApplicationsByDateQuery request, CancellationToken cancellationToken)
        {
            return await _applicationService.GetApplicationsByDateAsync(request.Date,request.OpportunityId);
        }
    }

}
