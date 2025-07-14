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
        VolunteerOpportunity? GetByIdForUpdate(string id);

        Task<List<VolunteerOpportunity>> SearchByTitleAsync(string title);

        //public Task<List<VolunteerOpportunity>> GetAllWithIncludesAsync();
        public  Task<List<VolunteerOpportunity>> GetAllWithIncludesAsync(string organizationId);


        public Task<List<VolunteerOpportunity>> GetAllWithIncludesAsync();
        Task AddVolunteerToOpportunityAsync(string opportunityId, string volunteerId);

        public Task<List<VolunteerOpportunity>> GetAllWithOrganizationAsync();
        Task<List<VolunteerOpportunity>> SearchOpportunitiesAsync(string? status, string? orgName, string? location);

    }
}
