using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerAttendanceAndCert;
using Tatawwa3.Application.Dtos.VolunteerMangement;

namespace Tatawwa3.Application.Interfaces
{
    public interface IVolunteerService
    {
        Task<VolunteerSummaryDto> GetVolunteerSummaryAsync(string userId);
        Task<List<ParticipationDto>> GetVolunteerParticipationsAsync(string userId);

        Task<List<CertificateDto>> GetVolunteerCertificatesAsync(string volunteerId);
        Task<byte[]> DownloadCertificateAsync(string certificateId);
        Task<VolunteerProfileDetailsDto?> GetVolunteerProfileAsync(string volunteerId);

    }
}
