using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class Morag3aOpportunitiesHandler : IRequestHandler<Morag3aOpportunitiesQuery, List<OpportunityListDto>>
    {
        private readonly IOpportunity _opportunityRepo;
        private readonly IMapper _mapper;

        public Morag3aOpportunitiesHandler(IOpportunity opportunityRepo, IMapper mapper)
        {
            _opportunityRepo = opportunityRepo;
            _mapper = mapper;
        }
        public async Task<List<OpportunityListDto>> Handle(Morag3aOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            var opportunities = await _opportunityRepo.GetAllWithOrganizationAsync();
            var result = _mapper.Map<List<OpportunityListDto>>(opportunities);
            return result;
        }
    }
}
