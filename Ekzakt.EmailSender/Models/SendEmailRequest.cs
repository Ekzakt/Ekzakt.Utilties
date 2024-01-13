namespace Ekzakt.EmailSender.Models
{
    public class SendEmailRequest
    {
        public EmailAddress? From { get; set; }
        public List<EmailAddress> To { get; set; } = new();
        public List<EmailAddress>? Cc { get; set; } = new();
        public List<EmailAddress>? Bcc { get; set; } = new();
        public string Subject { get; set; } = string.Empty;
        public string HtmlBody { get; set; } = string.Empty;
        public string? TextBody { get; set; } = string.Empty;
    }
}
