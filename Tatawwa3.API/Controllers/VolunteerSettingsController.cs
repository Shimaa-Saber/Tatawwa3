using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.VolunteerSettings.Command;
using Tatawwa3.Application.CQRS.VolunteerSettings.Quiers;
using Tatawwa3.Application.Dtos.VolunteerSettings;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerSettingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VolunteerSettingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVolunteerSettings(string id)
        {
            var result = await _mediator.Send(new GetVolunteerSettingsQuery { VolunteerId = id });

            if (result == null) return NotFound("Volunteer not found");

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVolunteerSettings(string id, [FromForm] VolunteerSettingsDto dto)
        {
            var result = await _mediator.Send(new UpdateVolunteerSettingsCommand
            {
                VolunteerId = id,
                Dto = dto
            });

            if (!result) return NotFound("Volunteer not found or update failed");

            return Ok("تم تحديث البيانات بنجاح");
        }
    }

}

