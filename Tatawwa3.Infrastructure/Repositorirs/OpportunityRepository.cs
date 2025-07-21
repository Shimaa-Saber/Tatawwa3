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
            return _context.VolunteerOpportunities
                           .Where(o => !o.IsDeleted);
        }
        public VolunteerOpportunity? GetByIdWithIncludes(string id)
        {
            return _context.VolunteerOpportunities
                .Include(o => o.Organization)
                
                .Include(o => o.Applications)
                .FirstOrDefault(o => o.Id == id);


        }


        public VolunteerOpportunity? GetByIdForUpdate(string id)
        {
            return _context.VolunteerOpportunities
                .Include(o => o.Organization)
                .Include(o => o.Category)
                .Include(o => o.Team)
                .Include(o => o.RequiredSkills)
                .FirstOrDefault(o => o.Id == id && !o.IsDeleted);
        }

        public async Task<List<VolunteerOpportunity>> GetAllWithIncludesAsync()
        {
           return await _context.VolunteerOpportunities
               .Include(v => v.Organization)
               .Include(v => v.Applications)
               .Include(v => v.Reviews)
               .Where(v => !v.IsDeleted )

               .AsNoTracking()
               .ToListAsync();
        }

        //public async Task<List<VolunteerOpportunity>> GetAllWithIncludesAsync()
        //{
        //    return await _context.VolunteerOpportunities
        //        .Include(v => v.Organization)
        //        .Include(v => v.Applications)
        //        .Include(v => v.Reviews)
        //        .Where(v => !v.IsDeleted)

        //        .AsNoTracking()
        //        .ToListAsync();
        //}

        public async Task<List<VolunteerOpportunity>> GetAllWithIncludesAsync(string organizationId)
        {
            return await _context.VolunteerOpportunities
                .Include(v => v.Organization)
                .Include(v => v.Applications)
                .Include(v => v.Reviews)
                .Where(v => !v.IsDeleted && v.OrganizationID == organizationId)
                .Where(v => !v.IsDeleted
                 && v.OrganizationID == organizationId
                 && (v.Status == OpportunityStatus.Published || v.Status == OpportunityStatus.Completed))
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task AddVolunteerToOpportunityAsync(string opportunityId, string volunteerId)
        {
            var entity = new Participation
            {
                Id = Guid.NewGuid().ToString(),
                OpportunityId = opportunityId,
                VolunteerID = volunteerId,
                FirstCheckIn = DateTime.UtcNow
            };

            await _context.Participations.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<VolunteerOpportunity>> GetAllWithOrganizationAsync()
        {
            return await _context.VolunteerOpportunities
                .Include(v => v.Organization)
                .Where(v => !v.IsDeleted)
                .ToListAsync();
        }

        public async Task<List<VolunteerOpportunity>> SearchOpportunitiesAsync(string? status, string? orgName, string? location)
        {
            var query = _context.VolunteerOpportunities
                .Include(v => v.Organization)
                .Where(v => !v.IsDeleted)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(status))
            {
                if (Enum.TryParse(status, out OpportunityStatus parsedStatus))
                {
                    query = query.Where(v => v.Status == parsedStatus);
                }
            }

            if (!string.IsNullOrWhiteSpace(orgName))
            {
                query = query.Where(v => v.Organization.OrganizationName.Contains(orgName));
            }

            if (!string.IsNullOrWhiteSpace(location))
            {
                query = query.Where(v => v.Location.Contains(location));
            }

            return await query.ToListAsync();
        }

        public async Task<int> CountByStatusAsync(OpportunityStatus status)
        {
            return await _context.VolunteerOpportunities
                .CountAsync(o => o.Status == status && !o.IsDeleted);
        }







    }
}
