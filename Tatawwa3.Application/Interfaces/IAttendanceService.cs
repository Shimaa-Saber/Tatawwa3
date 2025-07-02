using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Attendace;

namespace Tatawwa3.Application.Interfaces
{
    public interface IAttendanceService
    {
        Task<List<AttendanceVolunteerDto>> GetOpportunityParticipantsAsync(string opportunityId);
        Task<bool> UpdateAttendanceAsync(UpdateAttendanceDto dto);

        Task<byte[]> ExportAttendanceReportPdfAsync(string opportunityId);
        Task<byte[]> ExportAttendanceReportExcelAsync(string opportunityId);

    }

}
