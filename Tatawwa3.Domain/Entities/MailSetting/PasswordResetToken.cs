using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities.MailSetting
{
    public class PasswordResetToken
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; }
        public string OtpCode { get; set; }
        public DateTime ExpiryTime { get; set; }

        public ApplicationUser ?User { get; set; }
    }
}
