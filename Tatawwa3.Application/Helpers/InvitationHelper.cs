using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.Helpers
{
   public class InvitationHelper
    {
        public static string GetStatusLabel(InvitationStatus? status)
        {
            return status switch
            {
                InvitationStatus.Accepted => "تم القبول",
                InvitationStatus.Rejected => "رفض",
                InvitationStatus.Pending => "لم يتم الرد",
                _ => "غير معروف"
            };
        }
    }
}
