using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using System.Security.Claims;
using Tatawwa3.Application.CQRS.Certificates.Commands;
using Tatawwa3.Application.CQRS.Certificates.Queries;
using Tatawwa3.Application.Dtos.Certificats;

namespace Tatawwa3.API.Controllers
{
    [EnableRateLimiting("FixedPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    
    public class CertificateController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CertificateController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("completed-participants/org/")]
        public async Task<IActionResult> GetAllCompletedParticipantsForOrganization()
        {
            var orgId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _mediator.Send(new GetAllCompletedOrgParQuery(orgId));
            return Ok(result);
        }

        [HttpGet("completed-participants")]
        public async Task<IActionResult> GetCompletedParticipants(string opp_title)
        {
           // var orgUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = await _mediator.Send(new GetCompletedParticipantsQuery(opp_title));
            return Ok(result);
        }

     

        [HttpPost("issue")]
        public async Task<IActionResult> IssueCertificate([FromBody] IssueCertificateDto dto)
        {
            var result = await _mediator.Send(new IssueCertificateCommand(dto));
            if (!result)
                return BadRequest("Failed to issue certificate. Participation may be invalid or already issued.");

            return Ok(new { success = true, message = "تم إصدار الشهادة بنجاح" });

        }

        [HttpPost("issue-group")]
        public async Task<IActionResult> IssueCertificatesForGroup([FromBody] IssueGroupCertificatesDto dto)
        {
            var count = await _mediator.Send(new IssueGroupCertificatesCommand(dto));

            if (count == 0)
            {
                return BadRequest(new
                {
                    success = false,
                    message = "لم يتم إصدار أي شهادة. ربما تم إصدارها مسبقًا."
                });
            }

            return Ok(new
            {
                success = true,
                message = $"✅ تم إصدار {count} شهادة بنجاح",
                issuedCount = count
            });
        }



    }
}
