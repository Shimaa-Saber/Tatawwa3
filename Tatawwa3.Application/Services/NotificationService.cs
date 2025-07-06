using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Notifications;
using Tatawwa3.Application.Hubs;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;
using static Tatawwa3.Application.Services.NotificationService;

namespace Tatawwa3.Application.Services
{
  
    
        public class NotificationService : INotificationService
        {
            private readonly Tatawwa3DbContext _context;
            private readonly IHubContext<NotificationHub> _hubContext;
            private readonly INotificationRepository _notificationRepo;
            private readonly IMapper _mapper;


        public NotificationService(Tatawwa3DbContext context, IHubContext<NotificationHub> hubContext,
            INotificationRepository notificationRepo, IMapper mapper
            )
            {
                _context = context;
                _hubContext = hubContext;
                _notificationRepo = notificationRepo;
                _mapper = mapper;
        }

            public async Task SendNotificationAsync(string userId, string title, string message)
            {
                
                var notification = new Notification
                {
                    Id = Guid.NewGuid().ToString(),
                    UserId = userId,
                    Title = title,
                    Message = message,
                    CreatedAt = DateTime.UtcNow,
                    IsRead = false
                };

                _context.Notifications.Add(notification);
                await _context.SaveChangesAsync();

                // ابعته عبر SignalR
                await _hubContext.Clients.Group(userId)
                    .SendAsync("ReceiveNotification", new
                    {
                        Title = title,
                        Message = message,
                        Date = notification.CreatedAt
                    });
            }

            public async Task<List<Notification>> GetUserNotificationsAsync(string userId)
            {
                return await _context.Notifications
                    .Where(n => n.UserId == userId)
                    .OrderByDescending(n => n.CreatedAt)
                    .ToListAsync();
            }

        public async Task<List<NotificationDto>> GetNotificationsAsync(string userId, int page, int pageSize)
        {
            var query = _notificationRepo.GetAll()
                .Where(n => n.UserId == userId)
                .OrderByDescending(n => n.CreatedAt);

            var paged = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return _mapper.Map<List<NotificationDto>>(paged);
        }


        public async Task<bool> MarkAsReadAsync(string notificationId)
        {
            var notification = _notificationRepo.GetByID(notificationId);
            if (notification == null)
                return false;

            notification.IsRead = true;
            _notificationRepo.UpdateByEntity(notification);
            await _notificationRepo.SaveChangesAsync();
            return true;
        }

        public async Task MarkAllAsReadAsync(string userId)
        {
            var notifications = await _notificationRepo
                .GetAll()
                .Where(n => n.UserId == userId && !n.IsRead)
                .ToListAsync();

            foreach (var notification in notifications)
                notification.IsRead = true;

            _notificationRepo.UpdateRange(notifications);
            await _notificationRepo.SaveChangesAsync();
        }

        public async Task<bool> DeleteNotificationAsync(string notificationId)
        {
            var notification =  _notificationRepo.GetByID(notificationId);
            if (notification == null)
                return false;

            _notificationRepo.Remove(notification.Id);
            await _notificationRepo.SaveChangesAsync();
            return true;
        }


    }

}

