using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_CSharp.Model
{
   public class MailArguments
    {
        public string MailTo { get; set; }
        public string Bcc { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string  Body { get; set; }
        public string SmtpHost { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public string MailFrom { get; set; }

    }
}
