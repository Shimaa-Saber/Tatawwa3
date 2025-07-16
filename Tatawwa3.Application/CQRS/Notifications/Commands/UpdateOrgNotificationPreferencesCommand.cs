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
    public record UpdateOrgNotificationPreferencesCommand(string UserId, UpdateOrgNotificationPreferencesDto PreferencesDto)
      : IRequest<string>;

    public class UpdateOrgNotificationPreferencesHandler : IRequestHandler<UpdateOrgNotificationPreferencesCommand, string>
    {
        private readonly INotificationPreferenceService _service;

        public UpdateOrgNotificationPreferencesHandler(INotificationPreferenceService service)
        {
            _service = service;
        }

        public async Task<string> Handle(UpdateOrgNotificationPreferencesCommand request, CancellationToken cancellationToken)
        {
            await _service.UpdateOrgPreferencesAsync(request.UserId, request.PreferencesDto);
            return "تم حفظ التفضيلات بنجاح ✅";
        }
    }

}
