using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerTeams;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.Interfaces
{
    public interface IVolunteerTeamRepository :IGeneric<VolunteerOpportunity>
    {
        Task<List<VolunteerTeamDto>> GetAllTeamsAsync(CancellationToken cancellationToken);
    }
}
