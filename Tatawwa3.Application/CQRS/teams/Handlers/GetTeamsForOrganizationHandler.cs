using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class GetTeamsForOrganizationHandler : IRequestHandler<GetTeamsForOrganizationQuery, List<TeamForOrganizationDto>>
    {
        private readonly Tatawwa3DbContext _context;

        public GetTeamsForOrganizationHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<List<TeamForOrganizationDto>> Handle(GetTeamsForOrganizationQuery request, CancellationToken cancellationToken)
        {
            return await _context.Teams
                .Where(t => t.OrganizationID == request.OrganizationId)
                .Select(t => new TeamForOrganizationDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    CreationDate = t.CreationDate,
                    MembersCount = t.Members != null ? t.Members.Count() : 0
                })
                .ToListAsync();
        }
    }
}