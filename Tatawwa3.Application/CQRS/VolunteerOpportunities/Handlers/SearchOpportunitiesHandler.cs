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
    public class SearchOpportunitiesHandler : IRequestHandler<SearchOpportunitiesQuery, List<OpportunityListDto>>
    {
        private readonly IOpportunity _opportunityRepo;
        private readonly IMapper _mapper;

        public SearchOpportunitiesHandler(IOpportunity opportunityRepo, IMapper mapper)
        {
            _opportunityRepo = opportunityRepo;
            _mapper = mapper;
        }

        public async Task<List<OpportunityListDto>> Handle(SearchOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            var opportunities = await _opportunityRepo.SearchOpportunitiesAsync(
                request.SearchDto.Status,
                request.SearchDto.OrganizationName,
                request.SearchDto.StartDate
            );

            return _mapper.Map<List<OpportunityListDto>>(opportunities);
        }
    }
}
