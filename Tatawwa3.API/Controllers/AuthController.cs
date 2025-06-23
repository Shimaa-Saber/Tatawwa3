using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.Auth.Commands;
using Tatawwa3.Application.Dtos.AuthDtos;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register-volunteer")]
        public async Task<IActionResult> RegisterVolunteer([FromBody] RegisterVolunteerDto dto)
        {
            await _mediator.Send(new RegisterVolunteerCommand(dto));
            return Ok("Volunteer registered successfully.");
        }

        [HttpPost("register-organization")]
        public async Task<IActionResult> RegisterOrganization(RegisterOrganizationDto dto)
        {
            await _mediator.Send(new RegisterOrganizationCommand(dto));
            return Ok(new { Message = "Organization registered successfully" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var token = await _mediator.Send(new LoginCommand
            {
                Email = dto.Email,
                Password = dto.Password
            });

            return Ok(new { token });
        }


    }
}
