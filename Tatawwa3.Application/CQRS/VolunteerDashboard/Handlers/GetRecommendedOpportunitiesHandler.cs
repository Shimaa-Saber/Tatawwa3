using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.VolunteerDashboard.Queries;
using Tatawwa3.Application.Dtos.VolunteerDashboard;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerDashboard.Handlers
{
    public class GetRecommendedOpportunitiesHandler : IRequestHandler<GetRecommendedOpportunitiesQuery, List<RecommendedOpportunityDto>>
    {
        private readonly IRecommendedOpportunityService _service;

        public GetRecommendedOpportunitiesHandler(IRecommendedOpportunityService service)
        {
            _service = service;
        }

        public async Task<List<RecommendedOpportunityDto>> Handle(GetRecommendedOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetRecommendedOpportunitiesAsync(request.UserId);
        }
    }
}
