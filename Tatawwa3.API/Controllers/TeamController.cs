using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Team.Commands;
using Tatawwa3.Application.CQRS.teams.Queries;
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

        [HttpGet("GetAllVolunteerTeams")]
        public async Task<IActionResult> GetAllVolunteerTeams()
        {
            var query = new GetAllVolunteerTeamQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("by-city")]
        public async Task<IActionResult> GetTeamsByCity([FromQuery] string city)
        {
            var result = await _mediator.Send(new GetTeamsByCityQuery(city));
            return Ok(result);
        }

        [HttpGet("by-name")]
        public async Task<IActionResult> GetTeamsByName([FromQuery] string name)
        {
            var result = await _mediator.Send(new GetTeamsByNameQuery(name));
            return Ok(result);
        }

        [HttpGet("by-category")]
        public async Task<IActionResult> GetTeamsByCategory([FromQuery] string category)
        {
            if (string.IsNullOrWhiteSpace(category))
                return BadRequest("Category is required.");

            var query = new GetTeamsByCategoryQuery(category);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
