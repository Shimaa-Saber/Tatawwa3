using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;
using Tatawwa3.Application.CQRS.VolunteerOpportunitiesss.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Application.ViewModels;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageController : ControllerBase
    {
        
            private readonly IMediator _mediator;

            public HomePageController(IMediator mediator)
            {
                _mediator = mediator;
            }
            [HttpGet("Opportunities")]
            public async Task<ActionResult<List<OpportunityHomeDto>>> GetAll()
            {
                var result = await _mediator.Send(new GetAllVolunteerOpportunitiesQuery());
                return Ok(result);
            }


        [HttpGet("active-volunteers/count")]
        public async Task<IActionResult> GetActiveVolunteersCount()
        {
            var count = await _mediator.Send(new GetActiveVolunteersCountQuery());
            return Ok(count);
        }


        [HttpGet("total-volunteersOpportunites-hours")]
        public async Task<IActionResult> GetTotalVolunteerHours()
        {
            var totalHours = await _mediator.Send(new GetTotalVolunteerHoursQuery());
            return Ok(totalHours);
        }

    }
}
