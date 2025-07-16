using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.teams.Commands;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class RemoveTeamMemberHandler : IRequestHandler<RemoveTeamMemberCommand, bool>
    {
        private readonly Tatawwa3DbContext _context;

        public RemoveTeamMemberHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(RemoveTeamMemberCommand request, CancellationToken cancellationToken)
        {
            var teamMember = await _context.TeamMembers
                .FirstOrDefaultAsync(x => x.TeamID == request.TeamId && x.VolunteerID == request.VolunteerId);

            if (teamMember == null)
                return false;

            _context.TeamMembers.Remove(teamMember);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}