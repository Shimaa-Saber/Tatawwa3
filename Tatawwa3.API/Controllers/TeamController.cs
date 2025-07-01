using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tatawwa3.Application.CQRS.Team.Commands;
using Tatawwa3.Application.CQRS.teams.Commands;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController: ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IGeneric<VolunteerProfile> _volunteerRepo;

        public TeamController(IMediator mediator, IGeneric<VolunteerProfile> volunteerRepo)
        {
            _mediator = mediator;
            _volunteerRepo = volunteerRepo;
        }

        [HttpGet("Team-Detailes{id}")]
        public async Task<ActionResult<TeamDetailsDto>> GetTeamDetails(string id)
        {
            var result = await _mediator.Send(new GetTeamDetailsQuery(id));
            return Ok(result);
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



        [Authorize]

        [HttpPost("request")]
        public async Task<IActionResult> SendJoinRequest([FromBody] JoinRequestDto dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var volunteer = await _volunteerRepo.FirstOrDefaultAsync(v => v.UserID == userId);
            if (volunteer == null)
                return NotFound("لم يتم العثور على الملف الشخصي للمتطوع");


            var command = new SendJoinRequestCommand(dto, volunteer.Id);
            await _mediator.Send(command);
            return Ok("تم إرسال طلب الانضمام بنجاح");
        }
    }
}
