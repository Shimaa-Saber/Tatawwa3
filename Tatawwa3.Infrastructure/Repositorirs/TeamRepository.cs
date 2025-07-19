using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Infrastructure.Repositorirs
{
    public class TeamRepository: GenericRepository<Team>, ITeamRepository

    {
        private readonly Tatawwa3DbContext _context;


        public TeamRepository(Tatawwa3DbContext context):base(context)
        {
            _context = context;
        }
        // public IQueryable<Team> GetAllTeams()
        // {
        //     return _context.Teams.AsQueryable();
        //}

        public IQueryable<Team> GetAllTeams()
        {
            return _context.Teams
                .Include(t => t.Category)
                .Include(t => t.Organization)
                .Include(t => t.Members); // عشان CurrentMembersCount يشتغل كمان
        }


        public List<string> GetAllTeamNames()
        {
            return _context.Teams
                           .Where(t => !string.IsNullOrEmpty(t.Name))
                           .Select(t => t.Name)
                           .Distinct()
                           .ToList();
        }
        public List<string> GetTeamNamesByOrganizationId(string organizationId)
        {
            return _context.Teams
                           .Where(t => t.OrganizationID == organizationId && !string.IsNullOrEmpty(t.Name))
                           .Select(t => t.Name)
                           .Distinct()
                           .ToList();
        }

        public async Task AddVolunteerToTeamAsync(string teamId, string volunteerId)
        {
            var volunteerTeam = new TeamMember
            {
                Id = Guid.NewGuid().ToString(),
                TeamID = teamId,
                VolunteerID = volunteerId,
                JoinDate = DateTime.UtcNow
            };

            _context.TeamMembers.Add(volunteerTeam);
            await _context.SaveChangesAsync();
        }


       







    }
}
