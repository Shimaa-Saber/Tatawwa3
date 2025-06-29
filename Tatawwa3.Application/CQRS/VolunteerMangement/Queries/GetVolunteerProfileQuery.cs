using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerMangement;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerMangement.Queries
{
    public class GetVolunteerProfileQuery : IRequest<VolunteerProfileDto>
    {
        public string UserId { get; set; }
        public GetVolunteerProfileQuery(string userId) => UserId = userId;
    }

    public class GetVolunteerProfileHandler : IRequestHandler<GetVolunteerProfileQuery, VolunteerProfileDto>
    {
        private readonly IApplicationService _volunteerService;

        public GetVolunteerProfileHandler(IApplicationService volunteerService)
        {
            _volunteerService = volunteerService;
        }

        public async Task<VolunteerProfileDto> Handle(GetVolunteerProfileQuery request, CancellationToken cancellationToken)
        {
            return await _volunteerService.GetVolunteerProfileAsync(request.UserId);
        }
    }
}
