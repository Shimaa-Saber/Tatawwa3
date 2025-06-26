using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.VolunteerDashboard.Queries;

namespace Tatawwa3.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VolunteerDashboardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VolunteerDashboardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("my-Opportunites")]
        public async Task<IActionResult> GetMyApplications([FromQuery] string volunteerId)
        {
            var result = await _mediator.Send(new GetVolunteerDashboardQuery(volunteerId));
            return Ok(result);
        }
    }
}
