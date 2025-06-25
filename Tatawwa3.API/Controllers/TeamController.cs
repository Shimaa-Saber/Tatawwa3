using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Team.Commands;
using Tatawwa3.Application.Dtos.Teams;
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

        [HttpPost("CreateTeam")]
        public async Task<IActionResult> CreateTeam([FromBody] CreateTeamDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var command =new CreateTeamCommand(dto);
             await _mediator.Send(command);

            return Ok();
        }
    }
}
