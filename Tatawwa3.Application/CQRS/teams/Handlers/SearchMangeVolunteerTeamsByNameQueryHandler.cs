using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class SearchMangeVolunteerTeamsByNameQueryHandler : IRequestHandler<SearchMangeVolunteerTeamsByNameQuery, List<MangeVolunteerTeamsDto>>
    {
        private readonly Tatawwa3DbContext _context;

        public SearchMangeVolunteerTeamsByNameQueryHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<List<MangeVolunteerTeamsDto>> Handle(SearchMangeVolunteerTeamsByNameQuery request, CancellationToken cancellationToken)
        {
            return await _context.Teams
                .Include(t => t.Organization)
                .Include(t => t.Members)
                .Where(t => t.Name.Contains(request.Name))
                .Select(t => new MangeVolunteerTeamsDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    CreationDate = t.CreationDate,
                    Status = t.Status,
                    OrganizationName = t.Organization.OrganizationName,
                    ActualMembersCount = t.Members.Count()
                    //ActualMembersCount = t.Members.Count(m => m.Status == TeamMemberStatus.Accepted)
                })
                .ToListAsync(cancellationToken);
        }
    }
}
