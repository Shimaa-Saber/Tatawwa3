using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.teams.Commands;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MangeVolunteerTeamsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MangeVolunteerTeamsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpDelete("Delet_Team{teamId}")]
        public async Task<IActionResult> Delete(string teamId)
        {
            await _mediator.Send(new DeleteVolunteerTeamCommand { TeamId = teamId });
            return NoContent();
        }


        [HttpPut("UpdateVolunteerTeam{id}")]
        public async Task<IActionResult> UpdateTeam(string id, [FromBody] UpdateTeamDto dto)
        {
            var command = new UpdateTeamCommand
            {
                TeamId = id,
                Dto = dto
            };

            await _mediator.Send(command);

            

            return Ok();
        }

            [HttpGet("GetTeamsStatistics")]
            public async Task<ActionResult<TeamsStatisticsDto>> GetTeamsStatistics()
            {
                var result = await _mediator.Send(new GetTeamsStatisticsQuery());
                return Ok(result);
            }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllTeams()
        {
            var result = await _mediator.Send(new GetMangeVolunteerTeamsQuery());
            return Ok(result);
        }

    
        [HttpGet("search")]
        public async Task<IActionResult> SearchTeams([FromQuery] string name)
        {
            var result = await _mediator.Send(new SearchMangeVolunteerTeamsByNameQuery(name));
            return Ok(result);
        }
    }
}
