using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Tatawwa3.Application.CQRS.VolunteerOpportunitiesss.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunitiesss.Handlers
{
    public class GetTotalVolunteerHoursHandler : IRequestHandler<GetTotalVolunteerHoursQuery, int>
    {
        private readonly Tatawwa3DbContext _context;

        public GetTotalVolunteerHoursHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(GetTotalVolunteerHoursQuery request, CancellationToken cancellationToken)
        {
            var total = await _context.VolunteerOpportunities
           .Where(v => v.TotalHours.HasValue)
           .SumAsync(v => v.TotalHours.Value, cancellationToken);

            return total;
        }
    }
}
