using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.teams.Commands;
using Tatawwa3.Application.CQRS.teams.Queries;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]



    public class ManageTeamsForOrganizationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ManageTeamsForOrganizationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpDelete("{teamId}/volunteers/{volunteerId}")]
        public async Task<IActionResult> RemoveTeamMember(string teamId, string volunteerId)
        {
            var result = await _mediator.Send(new RemoveTeamMemberCommand(teamId, volunteerId));
            if (!result)
                return NotFound("Team member not found.");

            return Ok("Volunteer removed from team.");
        }

        [HttpGet("{teamId}/members")]
        public async Task<IActionResult> GetTeamMembers(string teamId)
        {
            var result = await _mediator.Send(new GetTeamMembersQuery(teamId));
            return Ok(result);
        }


        [HttpGet("ManageTeams/{organizationId}")]
        public async Task<IActionResult> GetTeamsForOrganization(string organizationId)
        {
            var teams = await _mediator.Send(new GetTeamsForOrganizationQuery(organizationId));
            return Ok(teams);
        }
    }
}
