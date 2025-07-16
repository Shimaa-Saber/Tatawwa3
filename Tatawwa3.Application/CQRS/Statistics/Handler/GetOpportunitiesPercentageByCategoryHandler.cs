using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.Statistics.Queries;
using Tatawwa3.Application.Dtos;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.Statistics.Handler
{
    public class GetOpportunitiesPercentageByCategoryHandler
     : IRequestHandler<GetOpportunitiesPercentageByCategoryQuery, List<CategoryPercentageDto>>
    {
        private readonly Tatawwa3DbContext _context;

        public GetOpportunitiesPercentageByCategoryHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryPercentageDto>> Handle(
            GetOpportunitiesPercentageByCategoryQuery request,
            CancellationToken cancellationToken)
        {
            var total = await _context.VolunteerOpportunities.CountAsync(cancellationToken);

            if (total == 0)
                return new List<CategoryPercentageDto>();

            var grouped = await _context.VolunteerOpportunities
                .Include(o => o.Category)
                .GroupBy(o => o.Category.Name)
                .Select(g => new CategoryPercentageDto
                {
                    Category = g.Key,
                    Percentage = Math.Round((g.Count() * 100.0) / total, 2)
                }).ToListAsync(cancellationToken);

            return grouped;
        }
    }
}
