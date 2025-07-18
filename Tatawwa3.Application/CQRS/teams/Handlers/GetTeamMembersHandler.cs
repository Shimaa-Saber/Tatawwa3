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
    public class GetTeamMembersHandler : IRequestHandler<GetTeamMembersQuery, List<TeamMemberDto>>
    {
        private readonly Tatawwa3DbContext _context;

        public GetTeamMembersHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        //public async Task<List<TeamMemberDto>> Handle(GetTeamMembersQuery request, CancellationToken cancellationToken)
        //{
        //    return await _context.TeamMembers
        //        .Where(tm => tm.TeamID == request.TeamId && tm.Status == TeamMemberStatus.Accepted)
        //        .Include(tm => tm.Volunteer)
        //            .ThenInclude(v => v.User)
        //        .Select(tm => new TeamMemberDto
        //        {
        //            VolunteerId = tm.VolunteerID,
        //            Name = tm.Volunteer.User != null ? tm.Volunteer.User.UserName : "Unknown",
        //            ProfileImageUrl = tm.Volunteer.ProfilePictureUrl ?? "",
        //            Role = tm.Role ?? ""
        //        })
        //        .ToListAsync();
        //}
        public async Task<List<TeamMemberDto>> Handle(GetTeamMembersQuery request, CancellationToken cancellationToken)
        {
            return await _context.TeamMembers
                .Where(tm => tm.TeamID == request.TeamId) // <-- شرط Accepted اتشال
                .Include(tm => tm.Volunteer)
                    .ThenInclude(v => v.User)
                .Select(tm => new TeamMemberDto
                {
                    VolunteerId = tm.VolunteerID,
                    Name = tm.Volunteer.User != null ? tm.Volunteer.User.UserName : "Unknown",
                    ProfileImageUrl = tm.Volunteer.ProfilePictureUrl ?? "",
                    Role = tm.Role ?? ""
                })
                .ToListAsync();
        }

    }
}