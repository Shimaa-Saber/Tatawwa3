using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Attendace;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Attendance.Queries
{
    public class GetOpportunityParticipantsQuery : IRequest<List<AttendanceVolunteerDto>>
    {
        public string OpportunityId { get; set; }

        public GetOpportunityParticipantsQuery(string opportunityId)
        {
            OpportunityId = opportunityId;
        }
    }
    public class GetOpportunityParticipantsHandler : IRequestHandler<GetOpportunityParticipantsQuery, List<AttendanceVolunteerDto>>
    {
        private readonly IAttendanceService _attendanceService;

        public GetOpportunityParticipantsHandler(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        public async Task<List<AttendanceVolunteerDto>> Handle(GetOpportunityParticipantsQuery request, CancellationToken cancellationToken)
        {
            return await _attendanceService.GetOpportunityParticipantsAsync(request.OpportunityId);
        }
    }

}
