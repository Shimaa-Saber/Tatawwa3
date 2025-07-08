using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Notifications;

namespace Tatawwa3.Application.Interfaces
{
    public interface INotificationPreferenceService
    {
        Task<NotificationPreferenceDto> GetPreferencesAsync(string userId);
        Task SavePreferencesAsync(string userId, NotificationPreferenceDto dto);

        Task UpdateOrgPreferencesAsync(string userId, UpdateOrgNotificationPreferencesDto dto);
        Task<UpdateOrgNotificationPreferencesDto> GetOrgPreferencesAsync(string userId);
    }

}
