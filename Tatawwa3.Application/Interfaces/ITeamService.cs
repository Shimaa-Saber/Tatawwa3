using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.Application.Interfaces
{
    public interface ITeamService
    {
        Task<TeamDetailsDto> GetTeamDetailsAsync(string teamId);
        Task SendJoinRequestAsync(JoinRequestDto dto, string volunteerId);

        Task<List<GetTeamaDto>> GetAllTeamsAsync();

        Task<List<GetTeamaDto>> GetTeamsByCityAsync(string city);
    }
}
