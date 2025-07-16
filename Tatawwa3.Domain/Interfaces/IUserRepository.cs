using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Domain.Interfaces
{
   public interface IUserRepository 
    {
        Task<int> CountByRoleAsync(UserType role);
        Task<List<(int Year, int Month, int Count)>> GetUserGrowthByMonthAsync();

        Task<int> CountAsync();

    }
}
