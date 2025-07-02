using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.OrganizationProfile_1.Queries;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.API.Controllers
{
    public class OrganizationsManagementController : Controller
    {
        private readonly IMediator _mediator;

        public OrganizationsManagementController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetOrganizationStatistics")]
        public async Task<ActionResult<OrganizationsStatisticsDTO>> GetOrganizationsStatistics()
        {
            var result = await _mediator.Send(new GetOrganizationsStatisticsQuery());
            return Ok(result);
        }

        [HttpGet("by-city")]
        public async Task<IActionResult> GetOrgabizationByCity([FromQuery] string city)
        {
            var result = await _mediator.Send(new GetOrganizationByCityQuery(city));
            return Ok(result);
        }

        [HttpGet("by-Name")]
        public async Task<IActionResult> GetOrgabizationByNamw([FromQuery] string name)
        {
            var result = await _mediator.Send(new GetOrganizationByCityQuery(name));
            return Ok(result);
        }


    }
}
