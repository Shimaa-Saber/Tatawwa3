using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.Statistics.Queries;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.Statistics.Handler
{
    public class GetNewVolunteersPercentageHandler : IRequestHandler<GetNewVolunteersPercentageQuery, double>
    {
        private readonly Tatawwa3DbContext _context;

        public GetNewVolunteersPercentageHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<double> Handle(GetNewVolunteersPercentageQuery request, CancellationToken cancellationToken)
        {
            var totalVolunteers = await _context.VolunteerProfiles.CountAsync(cancellationToken);
            if (totalVolunteers == 0)
                return 0;

            var last30Days = DateTime.UtcNow.AddDays(-30);

            var newVolunteers = await _context.VolunteerProfiles
                .CountAsync(v => v.CreatedAt >= last30Days, cancellationToken);

            var percentage = (double)newVolunteers / totalVolunteers * 100;
            return Math.Round(percentage, 2);
        }
    }
}