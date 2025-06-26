using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class GetAllVolunteerTeamHandler : IRequestHandler<GetAllVolunteerTeamQuery, List<GetTeamaDto>>
    {
        private readonly ITeamService _volunteerTeamService;

        public GetAllVolunteerTeamHandler(ITeamService volunteerTeamService)
        {
            _volunteerTeamService = volunteerTeamService;
        }

        public async Task<List<GetTeamaDto>> Handle(GetAllVolunteerTeamQuery request, CancellationToken cancellationToken)
        {
            return await _volunteerTeamService.GetAllTeamsAsync();
        }
    }
}
