using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    public class GetAllLocationsQueryHandler : IRequestHandler<GetAllLocationsQuery, List<string>>
    {
        private readonly IOpportunity _opportunity;

        public GetAllLocationsQueryHandler(IOpportunity opportunity)
        {
            _opportunity = opportunity;
        }

        public async Task<List<string>> Handle(GetAllLocationsQuery request, CancellationToken cancellationToken)
        {
            var allOpportunities =  _opportunity.GetAll(); 
            var distinctLocations = allOpportunities
                                    .Where(o => !string.IsNullOrEmpty(o.Location))
                                    .Select(o => o.Location)
                                    .Distinct()
                                    .ToList();
            return distinctLocations;
        }
    }
}
