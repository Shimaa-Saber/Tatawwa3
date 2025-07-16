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
    public class CountCompletedOpportunitiesHandler : IRequestHandler<CountCompletedOpportunitiesQuery, int>
    {
        private readonly IOpportunity _repo;

        public CountCompletedOpportunitiesHandler(IOpportunity repo)
        {
            _repo = repo;
        }

        public async Task<int> Handle(CountCompletedOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            return await _repo.CountByStatusAsync(OpportunityStatus.Completed);
        }
    }

}
