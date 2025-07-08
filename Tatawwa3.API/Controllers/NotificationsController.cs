using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tatawwa3.Application.CQRS.Notifications.Commands;
using Tatawwa3.Application.CQRS.Notifications.Queries;
using Tatawwa3.Application.Dtos.Notifications;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            var result = await _mediator.Send(new GetNotificationsQuery(userId, page, pageSize));
            return Ok(result);
        }

        [HttpPut("invitations/{id}/accept")]
        public async Task<IActionResult> AcceptInvitation(string id)
        {
            var result = await _mediator.Send(new AcceptInvitationCommand(id));
            return Ok(result);
        }

        [HttpPut("invitations/{id}/reject")]
        public async Task<IActionResult> RejectInvitation(string id)
        {
            var result = await _mediator.Send(new RejectInvitationCommand(id));
            return Ok(result);
        }

        [HttpPut("{id}/mark-as-read")]
        public async Task<IActionResult> MarkAsRead(string id)
        {
            var result = await _mediator.Send(new MarkNotificationAsReadCommand(id));
            if (!result)
                return NotFound("الإشعار غير موجود");

            return Ok("تم تمييز الإشعار كمقروء ✅");
        }

        [HttpPut("mark-all-as-read")]
        public async Task<IActionResult> MarkAllAsRead()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _mediator.Send(new MarkAllNotificationsAsReadCommand(userId));
            return Ok("تم تمييز كل الإشعارات كمقروء ✅");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _mediator.Send(new DeleteNotificationCommand(id));
            if (!result)
                return NotFound("الإشعار غير موجود.");

            return Ok("تم حذف الإشعار بنجاح");
        }

        [HttpGet("getAllOrgNotifications")]
        public async Task<IActionResult> Get()
        {
            var orgUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var notifications = await _mediator.Send(new GetOrgNotificationsQuery(orgUserId));
            return Ok(notifications);
        }

        [HttpGet("GetPreferencesNotif")]
        public async Task<IActionResult> GetPreferences()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _mediator.Send(new GetNotificationPreferencesQuery(userId));
            return Ok(result);
        }

        [HttpPut(" UpdatePreferencesNotif")]
        public async Task<IActionResult> UpdatePreferences([FromBody] NotificationPreferenceDto dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            await _mediator.Send(new UpdateNotificationPreferencesCommand(userId, dto));
            return Ok("تم حفظ التفضيلات");
        }

        [HttpGet("org-preferences")]
        public async Task<IActionResult> GetOrgPreferences()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _mediator.Send(new GetOrgNotificationPreferencesQuery(userId));
            return Ok(result);
        }

        [HttpPut("org-preferences")]
        public async Task<IActionResult> UpdateOrgPreferences([FromBody] UpdateOrgNotificationPreferencesDto dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _mediator.Send(new UpdateOrgNotificationPreferencesCommand(userId, dto));
            return Ok(result);
        }
        

    }

}
