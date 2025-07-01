using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerAttendanceAndCert;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerAttendanceAndCert.Queries
{
    public class GetVolunteerSummaryQuery : IRequest<VolunteerSummaryDto>
    {
        public string UserId { get; set; }

        public GetVolunteerSummaryQuery(string userId)
        {
            UserId = userId;
        }
    }

    public class GetVolunteerSummaryHandler : IRequestHandler<GetVolunteerSummaryQuery, VolunteerSummaryDto>
    {
        private readonly IVolunteerService _volunteerService;

        public GetVolunteerSummaryHandler(IVolunteerService volunteerService)
        {
            _volunteerService = volunteerService;
        }

        public async Task<VolunteerSummaryDto> Handle(GetVolunteerSummaryQuery request, CancellationToken cancellationToken)
        {
            return await _volunteerService.GetVolunteerSummaryAsync(request.UserId);
        }
    }

}
