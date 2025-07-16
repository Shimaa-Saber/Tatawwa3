using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Organization.quiers;
using Tatawwa3.Application.CQRS.Statistics.Queries;
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


        [HttpGet("GetOpportunitiesPercentageByCategory")]
        public async Task<IActionResult> GetPercentages()
        {
            var result = await _mediator.Send(new GetOpportunitiesPercentageByCategoryQuery());
            return Ok(result);
        }

        [HttpGet("GetVolunteersPercentage")]
        public async Task<IActionResult> GetVolunteersPercentage()
        {
            var result = await _mediator.Send(new GetVolunteersPercentageQuery());
            return Ok(new { percentage = result });
        }

        [HttpGet("GetNewVolunteersPercentage")]
        public async Task<IActionResult> GetNewVolunteersPercentage()
        {
            var result = await _mediator.Send(new GetNewVolunteersPercentageQuery());
            return Ok(new { percentage = result });
        }


        [HttpGet("weekly-volunteer-activity-ratio")]
        public async Task<IActionResult> GetWeeklyVolunteerActivityRatio()
        {
            var ratio = await _mediator.Send(new GetWeeklyVolunteerActivityRatioQuery());
            return Ok(ratio);
        }
    }
}
