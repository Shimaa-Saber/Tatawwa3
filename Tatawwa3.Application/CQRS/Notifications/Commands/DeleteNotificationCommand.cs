using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Notifications.Commands
{
    public class DeleteNotificationCommand : IRequest<bool>
    {
        public string NotificationId { get; set; }

        public DeleteNotificationCommand(string notificationId)
        {
            NotificationId = notificationId;
        }
    }

    public class DeleteNotificationHandler : IRequestHandler<DeleteNotificationCommand, bool>
    {
        private readonly INotificationService _service;

        public DeleteNotificationHandler(INotificationService service)
        {
            _service = service;
        }

        public async Task<bool> Handle(DeleteNotificationCommand request, CancellationToken cancellationToken)
        {
            return await _service.DeleteNotificationAsync(request.NotificationId);
        }
    }

}
