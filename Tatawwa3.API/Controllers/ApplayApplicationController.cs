using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.MakeApplication.Commands;
using Tatawwa3.Application.Dtos.ApplicationDtos;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize

    public class ApplayApplicationController : ControllerBase
    {
        private readonly IMediator mediator;

        public ApplayApplicationController(IMediator mediatorr)
        {
            mediator = mediatorr;
        }

        [HttpPost("apply")]
        public async Task<IActionResult> ApplyToOpportunity([FromForm] addApplicationDto dto)
        {
            var command = new ApplyToOpportunityCommand
            {
                addapplication = dto
            };

            var result = await mediator.Send(command);

            return Ok(new { message = result });
        }
    }
}
