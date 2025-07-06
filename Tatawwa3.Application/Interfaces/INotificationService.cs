using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Notifications;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendNotificationAsync(string userId, string title, string message);
        Task<List<Notification>> GetUserNotificationsAsync(string userId);
        Task<List<NotificationDto>> GetNotificationsAsync(string userId, int page, int pageSize);

        Task<bool> MarkAsReadAsync(string notificationId);

        Task MarkAllAsReadAsync(string userId);
        Task<bool> DeleteNotificationAsync(string notificationId);

        Task<List<NotificationDto>> GetOrganizationNotificationsAsync(string organizationUserId);
        

    }
}

