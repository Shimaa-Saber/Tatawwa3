using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tatawwa3.Application.CQRS.VolunteerAttendanceAndCert.Queries;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerAttendanceAndCertController : ControllerBase
    {
        private readonly IMediator _mediator;
        public VolunteerAttendanceAndCertController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("profile/summary")]
        public async Task<IActionResult> GetProfileSummary()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
                return Unauthorized("User ID not found");

            var query = new GetVolunteerSummaryQuery(userId);
            var result = await _mediator.Send(query);

            return Ok(result);
        }

       // [Authorize(Roles = "Volunteer")]
        [HttpGet("profile/participations")]
        public async Task<IActionResult> GetParticipations()
        {
            var result = await _mediator.Send(new GetVolunteerParticipationsQuery());
            return Ok(result);
        }


       // [Authorize(Roles = "Volunteer")]
        [HttpGet("certificates")]
        public async Task<IActionResult> GetVolunteerCertificates()
        {
            var volunteerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(volunteerId))
                return Unauthorized("User ID not found in token.");

            var result = await _mediator.Send(new GetVolunteerCertificatesQuery(volunteerId));
            return Ok(result);
        }

        [HttpGet("certificate/{id}/download")]
        public async Task<IActionResult> Download(string id)
        {
            var pdfBytes = await _mediator.Send(new DownloadCertificateQuery(id));
            return File(pdfBytes, "application/pdf", "certificate.pdf");
        }


    }
}
