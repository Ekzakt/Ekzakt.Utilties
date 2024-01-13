using Ekzakt.EmailSender.Contracts;
using Ekzakt.EmailSender.Models;
using Microsoft.Extensions.Logging;
using MimeKit;
using MailKit.Net.Smtp;
using Ekzakt.EmailSender.Configuration;
using Microsoft.Extensions.Configuration;

namespace Ekzakt.EmailSender;

public class SmtpEmailSenderService(
    ILogger<SmtpEmailSenderService> logger, 
    IConfiguration configuration) : IEmailSenderService
{

    private readonly ILogger<SmtpEmailSenderService> _logger = logger;
    private SmtpSenderOptions _options;
    private SendEmailRequest _sendEmailRequest = new();


    public async Task SendAsync(SendEmailRequest sendRequest, Action<SmtpSenderOptions>? options = null)
    {
        if (sendRequest is null)
        {
            throw new ArgumentNullException(nameof(SendEmailRequest));
        }

        if (options is not null)
        {
            options(_options);
        }
        
        _sendEmailRequest = sendRequest;

        await SendAsync();
    }




    #region Helpers

    private async Task SendAsync()
    {
        MimeMessage mimeMessage = BuildMimeMessage();

        using var smtp = new SmtpClient();

        await smtp.ConnectAsync(
            _options.Host, 
            _options.Port
        );

        await smtp.AuthenticateAsync(
            _options.UserName, 
            _options.Password
        );

        await smtp.SendAsync(mimeMessage);

        await smtp.DisconnectAsync(true);
    }


    private MimeMessage BuildMimeMessage()
    {
        MimeMessage mimeMessage = new();

        mimeMessage.Sender = new MailboxAddress(
                _sendEmailRequest?.From?.Name ?? _options.FromDisplayName,
                _sendEmailRequest?.From?.Address ?? _options.FromAddress);

        mimeMessage.Subject = GetEmailSubject(_sendEmailRequest?.Subject);

        mimeMessage.To.AddRange(ConvertFromEmailAddressList(_sendEmailRequest.To));
        mimeMessage.Cc.AddRange(ConvertFromEmailAddressList(_sendEmailRequest.Cc));
        mimeMessage.Bcc.AddRange(ConvertFromEmailAddressList(_sendEmailRequest.Bcc));

        mimeMessage.Body = BuildBody();

        return mimeMessage;
    }


    private MimeEntity BuildBody()
    {
        if (string.IsNullOrEmpty(_sendEmailRequest.HtmlBody))
        {
            throw new ArgumentNullException(nameof(BodyBuilder.HtmlBody));
        }

        BodyBuilder bodyBuilder = new();

        bodyBuilder.HtmlBody = _sendEmailRequest.HtmlBody;
        bodyBuilder.TextBody = _sendEmailRequest.TextBody ?? string.Empty;

        return bodyBuilder.ToMessageBody();
    }


    private InternetAddressList ConvertFromEmailAddressList(List<EmailAddress> emailAddresses)
    {
        InternetAddressList addressesList = new();

        foreach (var emailAddress in emailAddresses)
        {
            addressesList.Add(new MailboxAddress(emailAddress.Name, emailAddress.Address));
        }

        return addressesList;
    }


    private string? GetEmailSubject(string? subject)
    {
        bool isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";

        if (isDevelopment)
        {
            return $"*** DEV {subject} ***";
        }
        else
        {
            return subject;
        }
    }


    #endregion Helpers
}
