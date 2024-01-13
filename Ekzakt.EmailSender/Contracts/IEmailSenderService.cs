using Ekzakt.EmailSender.Configuration;
using Ekzakt.EmailSender.Models;

namespace Ekzakt.EmailSender.Contracts;

public interface IEmailSenderService
{
    Task SendAsync(SendEmailRequest request, Action<SmtpSenderOptions>? options = null);
}
