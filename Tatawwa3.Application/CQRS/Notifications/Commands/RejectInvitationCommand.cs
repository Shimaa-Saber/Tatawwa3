using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.Notifications.Commands
{
    public record RejectInvitationCommand(string InvitationId) : IRequest<string>;


    public class RejectInvitationHandler : IRequestHandler<RejectInvitationCommand, string>
    {
        private readonly IVolunteerInvitationReprosatry _invitationRepo;

        public RejectInvitationHandler(IVolunteerInvitationReprosatry invitationRepo)
        {
            _invitationRepo = invitationRepo;
        }

        public async Task<string> Handle(RejectInvitationCommand request, CancellationToken cancellationToken)
        {
            var invitation =  _invitationRepo.GetByID(request.InvitationId);
            if (invitation == null) return "الدعوة غير موجودة.";

            invitation.Status = InvitationStatus.Rejected;
            await _invitationRepo.SaveChangesAsync();

            return "تم رفض الدعوة.";
        }
    }

}
