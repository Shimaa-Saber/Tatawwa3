using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;
using Tatawwa3.Domain.Enums;


namespace Tatawwa3.Infrastructure.Repositorirs
{
    public class VolunteerOpportunityRepository : GenericRepository<VolunteerOpportunity>, IVolunteerOpportunityRepository
    {
        private readonly Tatawwa3DbContext _context;

        public VolunteerOpportunityRepository(Tatawwa3DbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> CountActiveOpportunitiesAsync()
        {
            return await _context.VolunteerOpportunities.CountAsync(v => v.Status == OpportunityStatus.Published);
        }

        
        
  


    }
}
