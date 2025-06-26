using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IQueryable<Team> GetAllTeams()
        {
            return _context.Teams.AsQueryable();
       }


    }
}
