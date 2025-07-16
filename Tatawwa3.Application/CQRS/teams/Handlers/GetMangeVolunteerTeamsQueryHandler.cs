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
    public class GetMangeVolunteerTeamsQueryHandler : IRequestHandler<GetMangeVolunteerTeamsQuery, List<MangeVolunteerTeamsDto>>
    {
        private readonly Tatawwa3DbContext _context;

        public GetMangeVolunteerTeamsQueryHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<List<MangeVolunteerTeamsDto>> Handle(GetMangeVolunteerTeamsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Teams
                .Where(t => !t.IsDeleted) // ✅ استبعاد الفرق المحذوفة
                .Include(t => t.Organization)
                .Include(t => t.Members)
                    .ThenInclude(m => m.Volunteer)
                .Select(t => new MangeVolunteerTeamsDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    Description = t.Description,
                    CreationDate = t.CreationDate,
                    Status = t.Status,
                    OrganizationName = t.Organization.OrganizationName,
                    ActualMembersCount = t.Members.Count(m =>
                        m.Status == TeamMemberStatus.Accepted &&
                        m.Volunteer != null &&
                        !m.Volunteer.IsBanned &&
                        !m.Volunteer.IsDeleted)
                })
                .ToListAsync(cancellationToken);
        }
    }
}
