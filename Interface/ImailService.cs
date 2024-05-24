using SendMail.Model;

namespace SendMail.Interface
{
    public interface ImailService
    {
        Task SendEmailAsAsync(MailRequest mailRequest);

    }
}
