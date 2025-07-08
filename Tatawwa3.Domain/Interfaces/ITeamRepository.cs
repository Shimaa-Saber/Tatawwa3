using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Domain.Interfaces
{
    public interface ITeamRepository:IGeneric<Team>
    {

        IQueryable<Team> GetAllTeams();
        List<string> GetAllTeamNames();
        Task AddVolunteerToTeamAsync(string teamId, string volunteerId);
        List<string> GetTeamNamesByOrganizationId(string organizationId);
    }
}
