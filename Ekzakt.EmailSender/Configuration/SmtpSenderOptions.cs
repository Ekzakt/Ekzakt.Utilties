namespace Ekzakt.EmailSender.Configuration;

public class SmtpSenderOptions
{
    public string OptionsName { get; set; } = "SmtpMailOptions";

    public string FromAddress { get; init; } = string.Empty;

    public string FromDisplayName { get; init; } = string.Empty;

    public string UserName { get; init; } = string.Empty;

    public string Password { get; init; } = string.Empty;

    public string Host { get; init; } = string.Empty;

    public int Port { get; init; }
}
