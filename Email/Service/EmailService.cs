using Email.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email.Service
{
    public class EmailService : IEmailService
    {
        public void SendEmail(EmailDTO request)
        {
            // create email message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("nick.jacobs@ethereal.email"));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;
            email.Body = new TextPart(TextFormat.Plain) { Text = request.Body };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            /*            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);*/
            smtp.Authenticate("nick.jacobs@ethereal.email", "QK2Dm45Tby1kVbt2qD");
            smtp.Send(email);
            smtp.Disconnect(true);
        }

    }
}
