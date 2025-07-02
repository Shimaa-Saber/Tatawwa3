using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Certificates.Commands;
using Tatawwa3.Application.CQRS.Certificates.Queries;
using Tatawwa3.Application.Dtos.Certificats;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CertificateController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("completed-participants/{opportunityId}")]
        public async Task<IActionResult> GetCompletedParticipants(string opportunityId)
        {
            var result = await _mediator.Send(new GetCompletedParticipantsQuery(opportunityId));
            return Ok(result);
        }

        [HttpPost("issue")]
        public async Task<IActionResult> IssueCertificate([FromBody] IssueCertificateDto dto)
        {
            var result = await _mediator.Send(new IssueCertificateCommand(dto));
            if (!result)
                return BadRequest("Failed to issue certificate. Participation may be invalid or already issued.");

            return Ok("Certificate issued successfully.");
        }

        [HttpPost("issue-group")]
        public async Task<IActionResult> IssueCertificatesForGroup([FromBody] IssueGroupCertificatesDto dto)
        {
            var count = await _mediator.Send(new IssueGroupCertificatesCommand(dto));
            return Ok($"{count} certificates issued successfully.");
        }


    }
}
