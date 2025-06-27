using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Tatawwa3.Application.Dtos.VolunteerDashboard;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Tatawwa3.Application.Services
{
    public class RecommendedOpportunityService : IRecommendedOpportunityService
    {
        private readonly Tatawwa3DbContext _context;
        private readonly IMapper _mapper;

        public RecommendedOpportunityService(Tatawwa3DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<RecommendedOpportunityDto>> GetRecommendedOpportunitiesAsync(string volunteerId)
        {
            // Get volunteer profile
            var volunteer = await _context.VolunteerProfiles
                .FirstOrDefaultAsync(v => v.Id == volunteerId);

            if (volunteer == null || volunteer.CategoryId == null)
                return new List<RecommendedOpportunityDto>();

            // Get already applied opportunity IDs
            var appliedIds = await _context.Applications
                .Where(a => a.VolunteerID == volunteerId)
                .Select(a => a.OpportunityID)
                .ToListAsync();

            // Get recommended opportunities
            var recommended = await _context.VolunteerOpportunities
               .Where(o => o.CategoryID == volunteer.CategoryId.Value.ToString() && !appliedIds.Contains(o.Id))
                .ProjectTo<RecommendedOpportunityDto>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return recommended;
        }
    }
}
