using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MediatR;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class GetOpportunityNamesHandler : IRequestHandler<GetOpportunityNamesQuery, List<OpportunityNameDto>>
    {
        private readonly Tatawwa3DbContext _context;

        public GetOpportunityNamesHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<List<OpportunityNameDto>> Handle(GetOpportunityNamesQuery request, CancellationToken cancellationToken)
        {
            var list = await _context.VolunteerOpportunities
                 .Select(o => new OpportunityNameDto
                 {
                    
                     Title = o.Title
                 })
                 .ToListAsync();

            return list;
        }
    }
}
