using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.AdminVolunteer.Commit;
using Tatawwa3.Application.CQRS.AdminVolunteer.Quieries;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminVolunteerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminVolunteerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("admin/volunteers")]
        public async Task<IActionResult> GetAllVolunteers([FromQuery] GetAllVolunteersForAdminQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("by-name")]
        public async Task<IActionResult> GetByName([FromQuery] string name)
        => Ok(await _mediator.Send(new GetAllVolunteersForAdminQuery { Name = name }));

        [HttpGet("by-city")]
        public async Task<IActionResult> GetByCity([FromQuery] string city)
            => Ok(await _mediator.Send(new GetAllVolunteersForAdminQuery { City = city }));

    
        [HttpGet("by-status")]
        public async Task<IActionResult> GetByStatus(string status)
        {
            VolunteerStatus? parsedStatus = null;

            if (!string.IsNullOrEmpty(status) && Enum.TryParse(status, true, out VolunteerStatus tempStatus))
            {
                parsedStatus = tempStatus;
            }

            var query = new GetAllVolunteersForAdminQuery
            {
                Status = parsedStatus
            };

            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("by-hours")]
        public async Task<IActionResult> GetByHours([FromQuery] float hours)
            => Ok(await _mediator.Send(new GetAllVolunteersForAdminQuery { Hours = hours }));


        [HttpPut("ban/{volunteerId}")]
        public async Task<IActionResult> BanVolunteer(string volunteerId)
        {
            var command = new BanVolunteerCommand { VolunteerId = volunteerId };
            var result = await _mediator.Send(command);

            if (!result)
                return NotFound("المتطوع غير موجود");

            return Ok("تم حظر المتطوع بنجاح");
        }
    }
}

