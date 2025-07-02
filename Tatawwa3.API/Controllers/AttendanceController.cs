using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Attendance.Commands;
using Tatawwa3.Application.CQRS.Attendance.Queries;
using Tatawwa3.Application.Dtos.Attendace;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AttendanceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("opportunities/{opportunityId}/participants")]
        public async Task<IActionResult> GetParticipants(string opportunityId)
        {
            var result = await _mediator.Send(new GetOpportunityParticipantsQuery(opportunityId));
            return Ok(result);
        }

        [HttpPut("attendance/update")]
        public async Task<IActionResult> UpdateAttendance([FromBody] UpdateAttendanceDto dto)
        {
            var result = await _mediator.Send(new UpdateAttendanceCommand(dto));
            if (!result)
                return NotFound("المشارك غير موجود.");

            return Ok("تم تعديل الحضور بنجاح");
        }


        [HttpGet("{opportunityId}/attendance-report/pdf")]
        public async Task<IActionResult> ExportAttendancePdf(string opportunityId)
        {
            var file = await _mediator.Send(new ExportAttendanceReportPdfQuery(opportunityId));
            return File(file, "application/pdf", $"attendance_{opportunityId}.pdf");
        }

        [HttpGet("{opportunityId}/attendance-report/excel")]
        public async Task<IActionResult> ExportAttendanceExcel(string opportunityId)
        {
            var file = await _mediator.Send(new ExportAttendanceReportExcelQuery(opportunityId));
            return File(file,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                $"attendance_{opportunityId}.xlsx");
        }




    }
}
