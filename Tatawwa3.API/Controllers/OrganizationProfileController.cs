using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Organization.commands;
using Tatawwa3.Application.CQRS.Organization.quiers;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationProfileController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrganizationProfileController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _mediator.Send(new GetOrganizationProfileByIdQuery(id));
            return Ok(result);
        }

        [HttpPost("request-deactivation")]
        public async Task<IActionResult> RequestDeactivation([FromQuery] string id)
        {
            var result = await _mediator.Send(new RequestAccountDeactivationCommand(id));
            return Ok(result);
        }

    }
}
