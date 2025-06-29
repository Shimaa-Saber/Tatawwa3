using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerAttendanceAndCert;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerAttendanceAndCert.Queries
{
    public class GetVolunteerParticipationsQuery : IRequest<List<ParticipationDto>> { }

    public class GetVolunteerParticipationsHandler : IRequestHandler<GetVolunteerParticipationsQuery, List<ParticipationDto>>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IVolunteerService _volunteerService;

        public GetVolunteerParticipationsHandler(IHttpContextAccessor httpContextAccessor, IVolunteerService volunteerService)
        {
            _httpContextAccessor = httpContextAccessor;
            _volunteerService = volunteerService;
        }

        public async Task<List<ParticipationDto>> Handle(GetVolunteerParticipationsQuery request, CancellationToken cancellationToken)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return await _volunteerService.GetVolunteerParticipationsAsync(userId);
        }
    }

}
