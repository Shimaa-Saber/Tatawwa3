using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Domain.Interfaces
{
    public interface IOpportunity:IGeneric<VolunteerOpportunity> 
    {

        Task<List<VolunteerOpportunity>> GetByLocation(string location);
        Task<List<VolunteerOpportunity>> GetByCategoryName(string categoryName);

        public IQueryable<VolunteerOpportunity> GetAllOpportunity();
        VolunteerOpportunity? GetByIdWithIncludes(string id);
        Task<List<VolunteerOpportunity>> SearchByTitleAsync(string title);
        public Task<List<VolunteerOpportunity>> GetAllWithIncludesAsync();
        Task AddVolunteerToOpportunityAsync(string opportunityId, string volunteerId);
    }
}
