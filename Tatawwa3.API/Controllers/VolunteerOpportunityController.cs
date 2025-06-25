using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;



namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerOpportunityController : ControllerBase
    {

        public IMediator mediator { get; set; }
        public VolunteerOpportunityController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]

        public async Task<IActionResult> GetallOpportunites()
        {
            var commands = new GetAllOpportunitiesQuery();
            var res = await mediator.Send(commands);
            return Ok(res);
        }

        [HttpGet("bylocation")]

        public async Task<IActionResult> GetOpportunityLocation(string location)
        {

            var query = new GetLocationOpportunitiesQuery(location);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("byCategory")]
        public async Task<IActionResult> GetOpportunityCategory(string CatName)
        {

            var query = new GetLocationOpportunitiesQuery(CatName);
            var result = await mediator.Send(query);
            return Ok(result);


        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOpportunityById(string id)
        {
            var query = new GetIdOpportunutyQuery(id);
            var result = await mediator.Send(query);

            //if (result == null)
            //    return NotFound(); 

            if (result == null)
                return NotFound(new { message = "❌ الفرصة التطوعية غير موجودة." });

            return Ok(result);
        }

    }
}
