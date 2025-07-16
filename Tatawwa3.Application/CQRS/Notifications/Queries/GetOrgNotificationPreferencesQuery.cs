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
    public class GetOrgNotificationPreferencesQuery:IRequest<UpdateOrgNotificationPreferencesDto>
    {
        public string UserId { get; set; }
        public GetOrgNotificationPreferencesQuery(string userId)
        {
            UserId = userId;
        }
    }
    public class GetOrgNotificationPreferencesHandler : IRequestHandler<GetOrgNotificationPreferencesQuery, UpdateOrgNotificationPreferencesDto>
    {
        private readonly INotificationPreferenceService _service;
        public GetOrgNotificationPreferencesHandler(INotificationPreferenceService service)
        {
            _service = service;
        }
        public async Task<UpdateOrgNotificationPreferencesDto> Handle(GetOrgNotificationPreferencesQuery request, CancellationToken cancellationToken)
        {
            return await _service.GetOrgPreferencesAsync(request.UserId);
        }
    }
}
