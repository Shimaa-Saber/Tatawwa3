using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.Application.Interfaces
{
    public interface IStatisticsService
    {
        Task<TeamsStatisticsDto> GetTeamsStatisticsAsync();
    }
}
