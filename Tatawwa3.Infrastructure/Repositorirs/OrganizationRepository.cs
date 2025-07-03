using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;




namespace Tatawwa3.Infrastructure.Repositorirs
{
public class OrganizationRepository:GenericRepository<OrganizationProfile>, IOrganizationRepository
    {

       
           


        private readonly Tatawwa3DbContext _context;

        public OrganizationRepository(Tatawwa3DbContext context) : base(context)
        {
            _context = context;
        }

            public IQueryable<OrganizationProfile> GetAll()
        {
            return _context.OrganizationProfiles.AsQueryable();
            
            
        }

        public async Task<int> CountOrganizationsAsync()
        {
            return await _context.OrganizationProfiles.CountAsync();

        }

        public async Task<List<string>> GetAllCitiesAsync()
        {
            var query = _context.OrganizationProfiles
                                .Where(o => !string.IsNullOrEmpty(o.City))
                                .Select(o => o.City.Trim())
                                .Distinct();

            return await query.ToListAsync();
        }


    }
}
