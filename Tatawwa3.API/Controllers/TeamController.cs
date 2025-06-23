using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Team.Commands;
namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController: ControllerBase
    {
        private readonly IMediator _mediator;

        public TeamController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateTeam([FromBody] CreateTeamCommand command)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var teamId = await _mediator.Send(command);

            return Ok(new { TeamId = teamId });
        }
    }
}
