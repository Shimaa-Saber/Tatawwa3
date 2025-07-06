using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Notifications.Commands
{
    public class MarkNotificationAsReadCommand : IRequest<bool>
    {
        public string NotificationId { get; set; }

        public MarkNotificationAsReadCommand(string notificationId)
        {
            NotificationId = notificationId;
        }
    }
    public class MarkNotificationAsReadHandler : IRequestHandler<MarkNotificationAsReadCommand, bool>
    {
        private readonly INotificationService _notificationService;

        public MarkNotificationAsReadHandler(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public async Task<bool> Handle(MarkNotificationAsReadCommand request, CancellationToken cancellationToken)
        {
            return await _notificationService.MarkAsReadAsync(request.NotificationId);
        }
    }

}
