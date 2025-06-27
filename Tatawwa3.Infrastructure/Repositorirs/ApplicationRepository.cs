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
    public class ApplicationRepository : GenericRepository<Application>, IApplicationRepository
    {
        private readonly Tatawwa3DbContext _context;
        public ApplicationRepository(Tatawwa3DbContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Application> GetApplicationsByVolunteerId(string volunteerId)
        {
       
            return _context.Applications.Where(a => a.Id == volunteerId).AsQueryable();
        }
    }
}
