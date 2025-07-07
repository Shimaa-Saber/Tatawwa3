using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerMangement.Queries;
using Tatawwa3.Application.Dtos.VolunteerMangement;

namespace Tatawwa3.Application.Interfaces
{
    public interface IApplicationService
    {
        Task<List<ApplicationDto>> GetAllApplicationsByOrganizationAsync(string orgUserId);
        Task<bool> AcceptApplicationAsync(string applicationId);

        Task<bool> RejectApplicationAsync(string applicationId);

        Task<bool> AddNoteAsync(string applicationId, string note);

        Task<VolunteerProfileDto> GetVolunteerProfileAsync(string userId);

        Task<List<ApplicationDto>> GetApplicationsByNameAsync(string name);
        Task<List<ApplicationDto>> GetApplicationsByStatusAsync(string status);
        Task<List<ApplicationDto>> GetApplicationsByDateAsync(DateTime date);

        Task<ApplicationStatisticsDto> GetApplicationStatisticsAsync();


    }
}
