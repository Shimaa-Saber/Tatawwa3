using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Organization.quiers;
using Tatawwa3.Application.Dtos.OrganizationProfile;
using Tatawwa3.Application.Dtos.OrganizationProfile;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class OrganizationManagement : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrganizationManagement(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getStatistics")]
        public async Task<ActionResult<TeamsStatisticsDto>> getDashboardStatisticsDTO()
        {
            var result = await _mediator.Send(new GetDashboardStatisticsQuery());
            return Ok(result);
        }
    }
}
