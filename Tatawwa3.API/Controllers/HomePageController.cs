using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;
using Tatawwa3.Application.ViewModels;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageController : ControllerBase
    {
        public class VolunteerOpportunityController : ControllerBase
        {
            private readonly IMediator _mediator;

            public VolunteerOpportunityController(IMediator mediator)
            {
                _mediator = mediator;
            }
            [HttpGet("Opportunities")]
            public async Task<ActionResult<List<VolunteerOpportunityVM>>> GetAll()
            {
                var result = await _mediator.Send(new GetAllVolunteerOpportunitiesQuery());
                return Ok(result);
            }

        }
    }
}
