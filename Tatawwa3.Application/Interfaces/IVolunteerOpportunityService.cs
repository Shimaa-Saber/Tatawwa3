using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.Interfaces
{
    public interface IVolunteerOpportunityService
    {
        Task<List<OpportunityHomeDto>> GetAllOpportunitiesAsync();
    }
}
