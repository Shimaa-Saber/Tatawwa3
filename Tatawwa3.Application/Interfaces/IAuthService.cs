using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.AuthDtos;

namespace Tatawwa3.Application.Interfaces
{
    public interface IAuthService
    {
        Task RegisterVolunteerAsync(RegisterVolunteerDto dto);
        Task RegisterOrganizationAsync(RegisterOrganizationDto dto);
        Task ForgetPasswordAsync(ForgotPasswordDto dto);

        Task<bool> VerifyOtpAsync(VerifyOtpDto dto);

        Task<bool> ResetPasswordAsync(ResetPasswordDto dto);

        Task<bool> ChangePasswordAsync(ChangePasswordDto dto, string userId);

        //public Task<string> GenerateOTPCode(string Email);
        //public Task<string> VerifyOTPCode(string email, string code);
        //public Task<string> ResetPassword(string email, string password);

    }
}
