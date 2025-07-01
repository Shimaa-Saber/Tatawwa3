using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Invitations.Commands;
using Tatawwa3.Application.CQRS.Invitations.Queries;
using Tatawwa3.Application.Dtos.InvitationDtos;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InvitationsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> AddInvitation([FromBody] AddInvitaon dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var command = new AddInvitationCommand(dto);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetSentInvitations()
        {
            var result = await _mediator.Send(new GetSentInvitationsQuery());
            return Ok(result); 
        }
    }
}
