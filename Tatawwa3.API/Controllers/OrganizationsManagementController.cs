using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Organization.quiers;
using Tatawwa3.Application.CQRS.OrganizationProfile_1.command;
using Tatawwa3.Application.CQRS.OrganizationProfile_1.Queries;
using Tatawwa3.Application.CQRS.Statistics.Command;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Domain.Enums;

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
            var result = await _mediator.Send(new GetOrganizationByNameQuery(name));
            return Ok(result);
        }
        [HttpGet("by-status")]
        public async Task<IActionResult> GetOrganizationsByStatus([FromQuery] OrganizationStatus status)
        {
            var result = await _mediator.Send(new GetOrganizationsByStatusQuery(status));
            return Ok(result);
        }

        [HttpPut("ban/{id}")]
        public async Task<IActionResult> BanOrganization(string id)
        {
            await _mediator.Send(new BanOrganizationCommand(id));
            return Ok(new { message = "Organization banned successfully" });
        }


        [HttpGet("all")]
        public async Task<IActionResult> GetAllOrganizations()
        {
            var result = await _mediator.Send(new GetAllOrganizationsQuery());
            return Ok(result);
        }


        [HttpPut("approve/{organizationId}")]
        public async Task<IActionResult> ApproveOrganization(string organizationId)
        {
            await _mediator.Send(new ApproveOrganizationCommand(organizationId));
            return Ok("Organization approved successfully.");
        }

    }
}
