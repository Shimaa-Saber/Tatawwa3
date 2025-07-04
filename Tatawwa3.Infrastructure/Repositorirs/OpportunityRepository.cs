using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Infrastructure.Data;
using Tatawwa3.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Domain.Enums;
using AutoMapper.QueryableExtensions;






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

        public async Task<List<VolunteerOpportunity>> SearchByTitleAsync(string title)
        {
            return await _context.VolunteerOpportunities
                .Where(o => o.Title.Contains(title)) 
                .ToListAsync();
        }



        public async Task<List<VolunteerOpportunity>> GetByCategoryName(string categoryName)
        {
            return await _context.VolunteerOpportunities
        .Where(v => _context.Categories
            .Any(c => c.Id == v.CategoryID && c.Name.Trim().ToLower() == categoryName.Trim().ToLower()))
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
                
                .Include(o => o.Applications)
                .FirstOrDefault(o => o.Id == id);


        }
        public async Task<List<VolunteerOpportunity>> GetAllWithIncludesAsync()
        {
            return await _context.VolunteerOpportunities
                .Include(v => v.Organization)
                .Include(v => v.Applications)
                .Include(v => v.Reviews)
                
                .AsNoTracking()
                .ToListAsync();
        }




    }
}
