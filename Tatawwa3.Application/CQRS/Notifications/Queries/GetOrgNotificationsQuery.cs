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
    public record GetOrgNotificationsQuery(string OrganizationUserId) : IRequest<List<NotificationDto>>;

    public class GetOrgNotificationsHandler : IRequestHandler<GetOrgNotificationsQuery, List<NotificationDto>>
    {
        private readonly INotificationService _notificationService;

        public GetOrgNotificationsHandler(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public async Task<List<NotificationDto>> Handle(GetOrgNotificationsQuery request, CancellationToken cancellationToken)
        {
            return await _notificationService.GetOrganizationNotificationsAsync(request.OrganizationUserId);
        }
    }

}
