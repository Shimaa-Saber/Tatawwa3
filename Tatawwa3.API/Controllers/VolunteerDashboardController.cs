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

        [HttpGet("submitted/{userId}")]
        public async Task<IActionResult> GetSubmittedOpportunities(string userId)
        {
            var result = await _mediator.Send(new GetVolunteerDashboardQuery(userId));
            return Ok(result);
        }


        [HttpGet("recommended")]
            public async Task<IActionResult> GetRecommended([FromQuery] string volunteerId)
            {
                var result = await _mediator.Send(new GetRecommendedOpportunitiesQuery(volunteerId));
                return Ok(result);
            }
        }
    }

