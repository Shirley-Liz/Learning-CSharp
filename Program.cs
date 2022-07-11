using Learning_CSharp.Model;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net.Mime;

namespace Learning_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mailArgs = new MailArguments
            {
                MailFrom = "<--From mail address from where mail should be sent -->",
                Password = "<--From mail address password-->",
                Name = "<-- From mail address name-->",
                MailTo = "<--To mail address to where mail should be received-->",
                Subject = "<-- Subject of the mail-->",
                Message = "<-- Message body of the email can contains HTML as well-->",
                Port = 587,
                SmtpHost = "smtp.gmail.com",
                Bcc = "<--BCC email id's separated by semicolon (;)-->"
            };

            List<Attachment> lstAttachments = new List<Attachment>
            {
                new Attachment("<--path of the attachment-->", MediaTypeNames.Image.Gif)
            };

            Dictionary<string, string> dictHeaders = new Dictionary<string, string>
            {
                {"<--key of the header-->", "<--Values of the header-->" }
            };

            Console.WriteLine(Mail.SendEmail(mailArgs, lstAttachments, true, dictHeaders).Item2);
            

        }
    }
}
