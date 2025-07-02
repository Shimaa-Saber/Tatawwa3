using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Infrastructure.Data;
using Tatawwa3.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Tatawwa3.Infrastructure.Repositorirs
{
 public class OpportunityRepository:GenericRepository<VolunteerOpportunity>, IOpportunity
    {
        private readonly Tatawwa3DbContext _context;
        protected readonly DbSet<VolunteerOpportunity> _dbSet;
        public OpportunityRepository(Tatawwa3DbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<VolunteerOpportunity>();

        }

        public async Task<List<VolunteerOpportunity>> GetByLocation(string location)
        {
            return await _dbSet
                .Where(v => v.Location == location)
                .ToListAsync();
        }


        public async Task<List<VolunteerOpportunity>> GetByCategoryName(string categoryName)
        {
            return await _dbSet
                .Include(v => v.Category)
                .Where(v => v.Category != null && v.Category.Name== categoryName)
                .ToListAsync();
        }

     
        public IQueryable<VolunteerOpportunity> GetAllOpportunity()
        {
            return _context.VolunteerOpportunities.AsQueryable();
        }
        public VolunteerOpportunity? GetByIdWithIncludes(string id)
        {
            return _context.VolunteerOpportunities
                .Include(o => o.Organization)
                .Include(o => o.RequiredSkills)
                .Include(o => o.Applications)
                .FirstOrDefault(o => o.Id == id);
        }


    }
}
