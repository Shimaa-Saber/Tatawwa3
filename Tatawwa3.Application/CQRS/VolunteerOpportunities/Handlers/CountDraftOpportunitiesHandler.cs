using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    public class CountDraftOpportunitiesHandler : IRequestHandler<CountDraftOpportunitiesQuery, int>
    {
        private readonly IOpportunity _repo;

        public CountDraftOpportunitiesHandler(IOpportunity repo)
        {
            _repo = repo;
        }

        public async Task<int> Handle(CountDraftOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            return await _repo.CountByStatusAsync(OpportunityStatus.Draft);
        }
    }

}
