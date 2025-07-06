using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Notifications.Commands
{
    public class MarkAllNotificationsAsReadCommand : IRequest
    {
        public string UserId { get; set; }

        public MarkAllNotificationsAsReadCommand(string userId)
        {
            UserId = userId;
        }
    }
    public class MarkAllNotificationsAsReadHandler : IRequestHandler<MarkAllNotificationsAsReadCommand>
    {
        private readonly INotificationService _notificationService;

        public MarkAllNotificationsAsReadHandler(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public async Task Handle(MarkAllNotificationsAsReadCommand request, CancellationToken cancellationToken)
        {
            await _notificationService.MarkAllAsReadAsync(request.UserId);
        }
    }

}
