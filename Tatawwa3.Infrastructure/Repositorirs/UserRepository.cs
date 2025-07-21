using System;
using System.Collections.Generic;
 using Microsoft.EntityFrameworkCore;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Infrastructure.Repositorirs
{
 public class UserRepository :  IUserRepository
    {
        private readonly Tatawwa3DbContext _context;

        public UserRepository(Tatawwa3DbContext context) 
        {
            _context = context;
        }
        public async Task<int> CountByRoleAsync(UserType role)
        {
            return await _context.Users.CountAsync(u => u.Role == role);
        }

        public async Task<List<(int Year, int Month, int Count)>> GetUserGrowthByMonthAsync()
        {
            return await _context.Users
                .GroupBy(u => new { u.CreatedAt.Year, u.CreatedAt.Month })
                .Select(g => new ValueTuple<int, int, int>(
                    g.Key.Year,
                    g.Key.Month,
                    g.Count()
                )).ToListAsync();
        }

        public async Task<int> CountAsync()
        {
            return await _context.Users.CountAsync();
        }
        public async Task<ApplicationUser> GetByIdAsync(string id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }
        //public async Task<int> CountActiveUsersAsync()
        //{
        //    return await _context.Users.CountAsync(u => !u.IsDeleted);
        //}


    }
}
