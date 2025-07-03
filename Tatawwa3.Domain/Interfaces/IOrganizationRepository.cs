using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Domain.Interfaces
{
   public interface IOrganizationRepository:IGeneric<OrganizationProfile>
    {

        public IQueryable<OrganizationProfile> GetAll();

        Task<int> CountOrganizationsAsync();
        Task<List<string>> GetAllCitiesAsync();


    }
}
