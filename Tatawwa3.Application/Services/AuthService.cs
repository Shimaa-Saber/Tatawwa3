using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.AuthDtos;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Entities.MailSetting;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly Tatawwa3DbContext _context;
        private readonly IEmailService _emailService;

        public AuthService(
            UserManager<ApplicationUser> userManager,
            Tatawwa3DbContext context
            , IEmailService emailService
            ) {
            _userManager = userManager;
            _context = context;
            _emailService = emailService;
        }

        public async Task RegisterVolunteerAsync(RegisterVolunteerDto dto)
        {

            var user = dto.Map<ApplicationUser>();
            var existingUser = await _userManager.FindByEmailAsync(dto.Email);
            if (existingUser != null)
                throw new Exception("Email already exists.");

            var result = await _userManager.CreateAsync(user, dto.Password);
            if (!result.Succeeded)
                throw new Exception("User creation failed: " + string.Join(", ", result.Errors.Select(e => e.Description)));


            var volunteer = dto.Map<VolunteerProfile>();
            volunteer.Id = user.Id;
            volunteer.UserID = user.Id;

            if (dto.ProfileImage != null)
            {
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", "ProfileImages");
                Directory.CreateDirectory(folderPath); // تأكد أن المجلد موجود

                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.ProfileImage.FileName)}";
                var filePath = Path.Combine(folderPath, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await dto.ProfileImage.CopyToAsync(stream);
                }

                
                volunteer.ProfilePictureUrl = fileName;
            }

            _context.VolunteerProfiles.Add(volunteer);
            await _context.SaveChangesAsync();
        }


        public async Task RegisterOrganizationAsync(RegisterOrganizationDto dto)
        {
            var user = dto.Map<ApplicationUser>();
            var existingUser = await _userManager.FindByEmailAsync(dto.Email);
            if (existingUser != null)
                throw new Exception("Email already exists.");

            var result = await _userManager.CreateAsync(user, dto.Password);
            if (!result.Succeeded)
                throw new Exception("User creation failed: " + string.Join(", ", result.Errors.Select(e => e.Description)));

            var profile = dto.Map<OrganizationProfile>();
            profile.UserID = user.Id;
            profile.Id = user.Id;

            if (dto.ProfileImage != null)
            {
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", "ProfileImages");
                Directory.CreateDirectory(folderPath); // تأكد أن المجلد موجود

                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.ProfileImage.FileName)}";
                var filePath = Path.Combine(folderPath, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await dto.ProfileImage.CopyToAsync(stream);
                }


                profile.ProfilePictureUrl = fileName;
            }



            _context.OrganizationProfiles.Add(profile);
            await _context.SaveChangesAsync();
        }






        public async Task ForgetPasswordAsync(ForgotPasswordDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
                return;

            var otp = new Random().Next(100000, 999999).ToString();
            await _userManager.RemoveAuthenticationTokenAsync(user, "Default", "ResetPasswordOtp");
            await _userManager.SetAuthenticationTokenAsync(user, "Default", "ResetPasswordOtp", otp);

            var subject = "رمز التحقق لإعادة تعيين كلمة المرور";
            var body = $"رمز التحقق الخاص بك هو: <b>{otp}</b>";


            var oldTokens = _context.passwordResetTokens.Where(t => t.UserId == user.Id);
            _context.passwordResetTokens.RemoveRange(oldTokens);

         
            var token = new PasswordResetToken
            {
                UserId = user.Id,
                OtpCode = otp,
                ExpiryTime = DateTime.UtcNow.AddSeconds(60)
            };

            await _context.passwordResetTokens.AddAsync(token);
            await _context.SaveChangesAsync();

            await _emailService.SendAsync(user.Email, subject, body);
        }

        public async Task<bool> VerifyOtpAsync(VerifyOtpDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
                return false;

            var token = await _context.passwordResetTokens
                .FirstOrDefaultAsync(t => t.UserId == user.Id && t.OtpCode == dto.Otp);

            if (token == null)
                return false;

            if (token.ExpiryTime < DateTime.UtcNow)
                return false;

            return true;
        }


        public async Task<bool> ResetPasswordAsync(ResetPasswordDto dto)
        {
            if (dto.NewPassword != dto.ConfirmPassword)
                return false;

            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user == null)
                return false;

         
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

          
            var result = await _userManager.ResetPasswordAsync(user, token, dto.NewPassword);

            if (result.Succeeded)
            {
             
                await _userManager.RemoveAuthenticationTokenAsync(user, "Default", "ResetPasswordOtp");
            }

            return result.Succeeded;
        }




        public async Task<bool> ChangePasswordAsync(ChangePasswordDto dto, string userId)
        {
            if (dto.NewPassword != dto.ConfirmPassword)
                return false;

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return false;

            var result = await _userManager.ChangePasswordAsync(user, dto.CurrentPassword, dto.NewPassword);
            return result.Succeeded;
        }






    }
}
