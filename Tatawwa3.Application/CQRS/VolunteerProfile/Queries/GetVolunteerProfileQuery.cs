using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerMangement;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerProfile.Queries
{
    public record GetVolunteerProfileQuery(string VolunteerId) : IRequest<VolunteerProfileDetailsDto?>;

    public class GetVolunteerProfileHandler : IRequestHandler<GetVolunteerProfileQuery, VolunteerProfileDetailsDto?>
    {
        private readonly IVolunteerService _service;

        public GetVolunteerProfileHandler(IVolunteerService service)
        {
            _service = service;
        }

        public async Task<VolunteerProfileDetailsDto?> Handle(GetVolunteerProfileQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetVolunteerProfileAsync(request.VolunteerId);
        }
    }

}
