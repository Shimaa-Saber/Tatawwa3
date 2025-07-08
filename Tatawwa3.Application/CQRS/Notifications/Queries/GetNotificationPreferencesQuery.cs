using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Notifications;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Notifications.Queries
{
    public record GetNotificationPreferencesQuery(string UserId) : IRequest<NotificationPreferenceDto>;

    public class GetNotificationPreferencesHandler : IRequestHandler<GetNotificationPreferencesQuery, NotificationPreferenceDto>
    {
        private readonly INotificationPreferenceService _service;

        public GetNotificationPreferencesHandler(INotificationPreferenceService service)
        {
            _service = service;
        }

        public async Task<NotificationPreferenceDto> Handle(GetNotificationPreferencesQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetPreferencesAsync(request.UserId);
        }
    }

}
