using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.AuthDtos;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.Services
{
    public class AuthService: IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly Tatawwa3DbContext _context;

        public AuthService(
            UserManager<ApplicationUser> userManager,
            Tatawwa3DbContext context
            ) { 
            _userManager = userManager;
            _context = context;
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

            _context.OrganizationProfiles.Add(profile);
            await _context.SaveChangesAsync();
        }




    }
}
