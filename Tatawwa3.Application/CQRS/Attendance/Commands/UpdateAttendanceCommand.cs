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
        public List<UpdateAttendanceDto> Updates{get; set; } = new List<UpdateAttendanceDto>();

        public UpdateAttendanceCommand(List<UpdateAttendanceDto> updates)
        {
            Updates = updates;

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
            return await _attendanceService.UpdateOpportunityAttendancesAsync(request.Updates);
        }
    }

}
