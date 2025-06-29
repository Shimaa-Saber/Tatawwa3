using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Application.Interfaces
{
    public interface ITeamService
    {
        Task<TeamDetailsDto> GetTeamDetailsAsync(string teamId);
        Task SendJoinRequestAsync(JoinRequestDto dto, string volunteerId);

        Task<List<GetTeamaDto>> GetAllTeamsAsync();

        Task<List<GetTeamaDto>> GetTeamsByCityAsync(string city);

        Task<List<GetTeamaDto>> GetTeamsByNameAsync(string name);
        Task<List<GetTeamaDto>> GetTeamsByCategoryAsync(string categoryName);
      
        Task  DEleteVolunteerTeamAsync(string Teamid);
        Task UpdateTeamAsync(UpdateTeamDto updateTeam,string teamId);

        Task<Team> GetTeamByIdAsync(string teamId);

    

      



    }
}
