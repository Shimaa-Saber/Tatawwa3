using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Commands;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;



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
        [HttpGet("Get All")]

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

        [HttpGet("Detailes{id}")]
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

        [HttpPut("Update{id}")]
        public async Task<IActionResult> UpdateOpportunity(string id, [FromBody] updateOportunityCommand command)
        {
            if (id != command.updateOportunuityDto.Id)
                return BadRequest(new { message = " id doesnt exist." });

            var result = await mediator.Send(command);

            if (result == null)
                return NotFound(new { message = " الفرصة التطوعية غير موجودة." });

            return Ok(new
            {
                message = " تم تحديث الفرصة بنجاح.",
                data = result
            });
        }

        [HttpDelete("Remove{id}")]

        public async Task<IActionResult> deleteOpportunity(string id)
        {
            var command = new DeleteOpportunityCommand(id);
            var result = await mediator.Send(command);

            if (result == null)
                return NotFound(new { message = " الفرصة التطوعية غير موجودة." });

            return Ok(new { message = result });
        }


        [HttpPost("Add")]
        public async Task<IActionResult> AddOpportunity([FromBody] AddOpportunityCommand command)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await mediator.Send(command);

            if (result == null)
                return BadRequest("باظت و متعملتش");

            return Ok(new
            {
                message = "الحمدلله قدر و لطف.",
                data = result
            });
        }





    }
}
