using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Attendance.Queries
{
    public class ExportAttendanceReportExcelQuery : IRequest<byte[]>
    {
        public string OpportunityId { get; set; }

        public ExportAttendanceReportExcelQuery(string opportunityId)
        {
            OpportunityId = opportunityId;
        }
    }

    public class ExportAttendanceReportExcelHandler : IRequestHandler<ExportAttendanceReportExcelQuery, byte[]>
    {
        private readonly IAttendanceService _attendanceService;

        public ExportAttendanceReportExcelHandler(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        public async Task<byte[]> Handle(ExportAttendanceReportExcelQuery request, CancellationToken cancellationToken)
        {
            return await _attendanceService.ExportAttendanceReportExcelAsync(request.OpportunityId);
        }
    }
}
