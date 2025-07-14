using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.VolunteerDashboard.Queries;
using Tatawwa3.Application.Dtos.VolunteerDashboard;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Application.Services;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.VolunteerDashboard.Handlers
{

    public class GetSubmittedOpportunitiesHandler
     : IRequestHandler<GetVolunteerDashboardQuery, List<SubmittedOpportunityDto>>
    {
        private readonly Tatawwa3DbContext _context;

        public GetSubmittedOpportunitiesHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

       
        public async Task<List<SubmittedOpportunityDto>> Handle(GetVolunteerDashboardQuery request, CancellationToken cancellationToken)
        {
            var applications = await _context.Applications
                .Include(a => a.Opportunity)
                    .ThenInclude(o => o.Organization)
                .Where(a => a.VolunteerID == request.UserId)
                .Select(a => new SubmittedOpportunityDto
                {
                    OpportunityTitle = a.Opportunity.Title,
                    OrganizationName = a.Opportunity.Organization.OrganizationName,
                    ApplicationDate = a.ApplicationDate,
                    Status = a.Status
                })
                .ToListAsync(cancellationToken);

            return applications; // ✅ لازم ترجع قيمة هنا
        }

    }

}
