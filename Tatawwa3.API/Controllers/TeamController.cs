﻿using MediatR;
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
    public class TeamController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IGeneric<VolunteerProfile> _volunteerRepo;

        public TeamController(IMediator mediator, IGeneric<VolunteerProfile> volunteerRepo)
        {
            _mediator = mediator;
            _volunteerRepo = volunteerRepo;
        }

        [HttpGet("{id}/Team-Detailes")]
        public async Task<ActionResult<TeamDetailsDto>> GetTeamDetails(string id)
        {
            var result = await _mediator.Send(new GetTeamDetailsQuery(id));
            if (result == null)
                return NotFound(new { message = "❌ هذا الفريق  غير موجودة." });
            return Ok(result);
        }

        [HttpPost("CreateTeam")]
        public async Task<IActionResult> CreateTeam([FromBody] CreateTeamDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var command = new CreateTeamCommand(dto);
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

        [HttpGet("team-names")]
        public async Task<IActionResult> GetTeamNames()
        {
            var result = await _mediator.Send(new GetAllTeamNamesQuery());
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





        [HttpGet("cities")]
        public async Task<IActionResult> GetAllCities()
        {
            var result = await _mediator.Send(new GetAllCitiesQuery());
            return Ok(result);
        }



        [HttpGet("categories")]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await _mediator.Send(new GetAllCategoriesQuery());
            return Ok(result);
        }


        [HttpGet("GetOpportunitesnames")]
        public async Task<IActionResult> GetOpportunityNames()
        {
            var result = await _mediator.Send(new GetOpportunityNamesQuery());
            return Ok(result);
        }


        [HttpGet("{organizationId}/team-names")]
        public async Task<IActionResult> GetTeamNamesByOrganizationId(string organizationId)
        {
            if (string.IsNullOrWhiteSpace(organizationId))
                return BadRequest(new { message = "يرجى إرسال id المنظمة." });

            var result = await _mediator.Send(new GetTeamNamesByOrganizationIdQuery(organizationId));
            return Ok(result);
        }

        [HttpGet("getTeamById{id}")]
        public async Task<ActionResult<UpdateTeamPageDto>> GetTeamForEdit(string id)
        {
            var result = await _mediator.Send(new GetTeamByIdQuery(id));
            return Ok(result);
        }

        [HttpPut("updateTeampage")]
        public async Task<IActionResult> UpdateTeamPage([FromBody] UpdateTeamPageDto dto)
        {
            await _mediator.Send(new UpdateTeamPageCommand(dto));
            return NoContent();
        }


        [HttpPut("accept/{teamId}/{volunteerId}")]
        public async Task<IActionResult> AcceptJoinRequest(string teamId, string volunteerId)
        {
            var result = await _mediator.Send(new RespondToJoinRequestCommand(teamId, volunteerId, true));
            return Ok(result);
        }

        [HttpPut("reject/{teamId}/{volunteerId}")]
        public async Task<IActionResult> RejectJoinRequest(string teamId, string volunteerId)
        {
            var result = await _mediator.Send(new RespondToJoinRequestCommand(teamId, volunteerId, false));
            return Ok(result);
        }

        [HttpPost("join-request/accept")]
        public async Task<IActionResult> AcceptJoinRequest([FromBody] RespondToJoinRequestByIdgdedCommand command)
        {
            command.IsAccepted = true;
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("join-request/reject")]
        public async Task<IActionResult> RejectJoinRequest([FromBody] RespondToJoinRequestByIdgdedCommand command)
        {
            command.IsAccepted = false;
            var result = await _mediator.Send(command);
            return Ok(result);
        }


    }
}
