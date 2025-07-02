using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Attendance.Queries
{
    public class ExportAttendanceReportPdfQuery : IRequest<byte[]>
    {
        public string OpportunityId { get; set; }

        public ExportAttendanceReportPdfQuery(string opportunityId)
        {
            OpportunityId = opportunityId;
        }
    }

    public class ExportAttendanceReportPdfHandler : IRequestHandler<ExportAttendanceReportPdfQuery, byte[]>
    {
        private readonly IAttendanceService _attendanceService;

        public ExportAttendanceReportPdfHandler(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        public async Task<byte[]> Handle(ExportAttendanceReportPdfQuery request, CancellationToken cancellationToken)
        {
            return await _attendanceService.ExportAttendanceReportPdfAsync(request.OpportunityId);
        }
    }
}
