using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Domain.Interfaces
{
   public interface IVolunteerProfileRepository:IGeneric<VolunteerProfile>
    {
        Task<float> GetTotalHoursAsync();
        Task<VolunteerProfile?> GetByUserIdAsync(string userId);
        Task Remove(VolunteerProfile volunteer);
    }
}
