using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Notifications;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Notifications.Commands
{
    public record UpdateNotificationPreferencesCommand(string UserId, NotificationPreferenceDto Preferences) : IRequest<Unit>; 

    public class UpdateNotificationPreferencesHandler : IRequestHandler<UpdateNotificationPreferencesCommand, Unit>
    {
        private readonly INotificationPreferenceService _service;

        public UpdateNotificationPreferencesHandler(INotificationPreferenceService service)
        {
            _service = service;
        }

        public async Task<Unit> Handle(UpdateNotificationPreferencesCommand request, CancellationToken cancellationToken)
        {
            await _service.SavePreferencesAsync(request.UserId, request.Preferences);
            return Unit.Value;
        }
    }

}
