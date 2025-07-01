using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.Application.Interfaces
{
    public interface IOrganizationService
    {
        Task<OrganizationsStatisticsDTO> GetStatisticsAsync();

        Task<List<OrganizationbasedFilterationDTO>> GetOrganizationByCityAsync(string city);
        Task<List<OrganizationbasedFilterationDTO>> GetOrganizationByNameAsync(string name);
    }
}
