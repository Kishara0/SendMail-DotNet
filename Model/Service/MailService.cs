using MimeKit;
using SendGrid.Helpers.Mail;
using SendMail.Interface;
using SendMail.Model;

namespace SendMail.Model.Service
{
    public class MailService : ImailService 
    {
        private readonly MailSettings _mailSettings;
        public MailService(MailSettings mailSettings) {
            _mailSettings = mailSettings;
            
        }
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;
            var builder = new BodyBuilder();
        }
    }
}
