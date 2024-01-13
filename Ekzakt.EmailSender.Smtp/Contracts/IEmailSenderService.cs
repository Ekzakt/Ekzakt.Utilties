using Ekzakt.EmailSender.Smtp.Configuration;
using Ekzakt.EmailSender.Smtp.Models;

namespace Ekzakt.EmailSender.Smtp.Contracts;

public interface IEmailSenderService
{
    Task SendAsync(SendEmailRequest request, Action<SmtpSenderOptions>? options = null);
}
