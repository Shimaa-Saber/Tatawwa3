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
    public class GetOpportunitiemangmentHandler : IRequestHandler<GetOpportunitiemangmentQuery, List<VolunteerOpportunityListDto>>
    {
        private readonly IOpportunity _opportunityRepo;
        private readonly IMapper _mapper;

        public GetOpportunitiemangmentHandler(IOpportunity opportunityRepo, IMapper mapper)
        {
            _opportunityRepo = opportunityRepo;
            _mapper = mapper;
        }

        public async Task<List<VolunteerOpportunityListDto>> Handle(GetOpportunitiemangmentQuery request, CancellationToken cancellationToken)
        {
            var opportunities = await _opportunityRepo.GetAllWithIncludesAsync();
            return _mapper.Map<List<VolunteerOpportunityListDto>>(opportunities);
        }
    }
}
