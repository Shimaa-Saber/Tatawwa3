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
    
    }
}
