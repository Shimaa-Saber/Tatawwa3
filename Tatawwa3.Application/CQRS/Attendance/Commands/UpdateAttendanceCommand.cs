using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Attendace;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Attendance.Commands
{
    public class UpdateAttendanceCommand : IRequest<bool>
    {
        public UpdateAttendanceDto Dto { get; set; }

        public UpdateAttendanceCommand(UpdateAttendanceDto dto)
        {
            Dto = dto;
        }
    }

    public class UpdateAttendanceHandler : IRequestHandler<UpdateAttendanceCommand, bool>
    {
        private readonly IAttendanceService _attendanceService;

        public UpdateAttendanceHandler(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        public async Task<bool> Handle(UpdateAttendanceCommand request, CancellationToken cancellationToken)
        {
            return await _attendanceService.UpdateAttendanceAsync(request.Dto);
        }
    }

}
