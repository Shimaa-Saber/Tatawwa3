using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Organization.commands;
using Tatawwa3.Application.CQRS.Organization.quiers;
using Tatawwa3.Application.Dtos.OrganizationProfile;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationProfileController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IOrganizationRepository _organizationRepository;

        public OrganizationProfileController(IMediator mediator, IOrganizationRepository organizationRepository)
        {
            _mediator = mediator;
            _organizationRepository = organizationRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _mediator.Send(new GetOrganizationProfileByIdQuery(id));
            return Ok(result);
        }

        [HttpGet("organization-cities")]
public async Task<IActionResult> GetOrganizationCities()
{
    var cities = await _mediator.Send(new GetAllCitiesQuery());
    return Ok(cities);
}


        [HttpPost("request-deactivation")]
        public async Task<IActionResult> RequestDeactivation([FromQuery] string id)
        {
            var result = await _mediator.Send(new RequestAccountDeactivationCommand(id));
            return Ok(result);
        }

        [HttpGet("organization-types")]
        public IActionResult GetOrganizationTypes()
        {
            var types = Enum.GetValues(typeof(OrganizationTypeEnum))
                            .Cast<OrganizationTypeEnum>()
                            .Select(e => new {
                                Id = (int)e,
                                Name = e.ToString()
                            });
            return Ok(types);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateOrganization([FromForm] UpdateOrganizationDto dto)
        {
            var command = new UpdateOrganizationCommand(dto);
            var result = await _mediator.Send(command);

            if (result == "Organization not found.")
                return NotFound(result);

            return Ok(result);
        }
        [HttpGet("getupdatedata/{id}")]
        public async Task<IActionResult> GetUpdateData(string id)
        {
            var result = await _mediator.Send(new GetUpdateDataQuery(id));
            return Ok(result);
        }


        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteOrganization(string id)
        {
            var command = new DeleteOrganizationCommand(id);
            var result = await _mediator.Send(command);

            if (result == "المنظمة غير موجودة.")
                return NotFound(result);

            return Ok(result);
        }

        [HttpGet("organization-names")]
        public async Task<IActionResult> GetOrganizationNames()
        {
            var result = await _mediator.Send(new GetAllOrganizationNamesQuery());
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var allOrganizations =  _organizationRepository.GetAll();
            return Ok(allOrganizations);
        }



    }
}
