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
    public class SearchOpportunitiesByTitleHandler : IRequestHandler<SearchOpportunitiesByTitleQuery, List<searchDto>>
    {
        private readonly IOpportunity _opportunity;
        private readonly IMapper _mapper;

        public SearchOpportunitiesByTitleHandler(IOpportunity opportunity, IMapper mapper)
        {
            _opportunity = opportunity;
            _mapper = mapper;
        }

        public async Task<List<searchDto>> Handle(SearchOpportunitiesByTitleQuery request, CancellationToken cancellationToken)
        {
            var result = await _opportunity.SearchByTitleAsync(request.Title);
            return _mapper.Map<List<searchDto>>(result);
        }
    }

}
