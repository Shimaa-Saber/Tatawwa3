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
    public class GetVolunteersPercentageHandler : IRequestHandler<GetVolunteersPercentageQuery, double>
    {
        private readonly Tatawwa3DbContext _context;

        public GetVolunteersPercentageHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<double> Handle(GetVolunteersPercentageQuery request, CancellationToken cancellationToken)
        {
            var totalUsers = await _context.Users.CountAsync(cancellationToken);
            if (totalUsers == 0)
                return 0;

            var volunteerCount = await _context.VolunteerProfiles.CountAsync(cancellationToken);
            var percentage = (double)volunteerCount / totalUsers * 100;
            return Math.Round(percentage, 2);
        }
    }

}
