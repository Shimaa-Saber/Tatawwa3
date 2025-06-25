using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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

        [HttpPost("forget-password")]
        public async Task<IActionResult> ForgetPassword([FromBody] ForgotPasswordDto dto)
        {
            await _mediator.Send(new ForgetPasswordCommand(dto));
            return Ok("لو الحساب موجود، تم إرسال رمز التحقق على البريد الإلكتروني.");
        }

        [HttpPost("verify-otp")]
        public async Task<IActionResult> VerifyOtp([FromBody] VerifyOtpDto dto)
        {
            var result = await _mediator.Send(new VerifyOtpCommand(dto));
            if (!result)
                return BadRequest("رمز تحقق غير صحيح ");

            return Ok("رمز تحقق صحيح");
        }


        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto dto)
        {
            if (dto.NewPassword != dto.ConfirmPassword)
                return BadRequest("كلمة المرور وتأكيدها غير متطابقين.");

            var result = await _mediator.Send(new ResetPasswordCommand(dto));
            if (!result)
                return BadRequest("فشل في إعادة تعيين كلمة المرور.");

            return Ok("تم إعادة تعيين كلمة المرور بنجاح.");
        }


        [Authorize]
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto dto)
        {
            if (dto.NewPassword != dto.ConfirmPassword)
                return BadRequest("كلمة المرور وتأكيدها غير متطابقين.");

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
                return Unauthorized("لم يتم العثور على المستخدم.");

            var result = await _mediator.Send(new ChangePasswordCommand(dto, userId));
            if (!result)
                return BadRequest("فشل تغيير كلمة المرور.");

            return Ok("تم تغيير كلمة المرور بنجاح.");
        }



    }
}
