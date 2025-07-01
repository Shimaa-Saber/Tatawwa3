using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Certificats;

namespace Tatawwa3.Application.Interfaces
{
    public interface ICertificateService
    {
        Task<List<CompletedParticipantDto>> GetCompletedParticipantsAsync(string opportunityId);
        Task<bool> IssueCertificateAsync(IssueCertificateDto dto);
        Task<int> IssueGroupCertificatesAsync(IssueGroupCertificatesDto dto);


    }
}
