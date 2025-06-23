using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunity.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunity.Handlers
{
    internal class GetLocationOpportunitiesQueryHandler : IRequestHandler<GetLocationOpportunitiesQuery, List<GetAllOpportunitiesDto>>
    {
        protected IOpportunity opportunity;
        protected IMapper mapper;
        public GetLocationOpportunitiesQueryHandler(IOpportunity opportunity, IMapper mapper)
        {
            this.opportunity = opportunity;
            this.mapper = mapper;
        }
        public async Task<List<GetAllOpportunitiesDto>> Handle(GetLocationOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            var opportunitiesLocation = await opportunity.GetByLocation(request.Location) ;
            return mapper.Map<List<GetAllOpportunitiesDto>>(opportunitiesLocation);
        }
    }
}
