﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Entities.MailSetting
{
    public class MailSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
