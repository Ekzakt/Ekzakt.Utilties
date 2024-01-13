using Ekzakt.EmailSender.Core.Models;

namespace Ekzakt.EmailSender.Core.Contracts;

public interface IEmailSenderService
{
    Task SendAsync(SendEmailRequest request, Action<IEmailSenderOptions>? options = null);
}
