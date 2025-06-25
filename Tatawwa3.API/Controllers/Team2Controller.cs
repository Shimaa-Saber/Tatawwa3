using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tatawwa3.Application.CQRS.teams.Commands;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Team2Controller : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IGeneric<VolunteerProfile> _volunteerRepo;

        public Team2Controller(IMediator mediator, IGeneric<VolunteerProfile> volunteerRepo)
        {
            _mediator = mediator;
            _volunteerRepo = volunteerRepo;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TeamDetailsDto>> GetTeamDetails(string id)
        {
            var result = await _mediator.Send(new GetTeamDetailsQuery(id));
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
