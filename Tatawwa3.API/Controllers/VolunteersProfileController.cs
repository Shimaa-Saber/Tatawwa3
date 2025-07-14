using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Organization.commands;
using Tatawwa3.Application.CQRS.VolunteerProfile.Commands;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteersProfileController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VolunteersProfileController(IMediator mediator)
        {
            _mediator = mediator;
        }





        [HttpDelete("deleteVolunter/{id}")]
        public async Task<IActionResult> deleteVolunter(string id)
        {
            var command = new DeleteVolunteerCommand(id);
            var result = await _mediator.Send(command);

            if (result == "المتطوع غير موجود.")
                return NotFound(result);

            return Ok(result);
        }
    }
}
