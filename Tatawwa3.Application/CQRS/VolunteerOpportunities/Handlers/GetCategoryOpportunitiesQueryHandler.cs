using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    internal class GetCategoryOpportunitiesQueryHandler : IRequestHandler<GetCategoryOpportunitiesQuery, List<searchDto>>
    {
        protected IOpportunity opportunity;
        protected IMapper mapper;
        public GetCategoryOpportunitiesQueryHandler(IOpportunity opportunity, IMapper mapper)
        {
            this.opportunity = opportunity;
            this.mapper = mapper;
        }
        public async Task<List<searchDto>> Handle(GetCategoryOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            var opportunitiesLCategory = await opportunity.GetByCategoryName(request.categoryname);
            return mapper.Map<List<searchDto>>(opportunitiesLCategory);

        }
    }
}
