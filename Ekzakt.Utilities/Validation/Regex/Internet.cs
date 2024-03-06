namespace Ekzakt.Utilities.Validation.Regex;

public static class Internet
{
    /// <summary>
    /// This regex matches domain names ensuring that they consist of 
    /// valid alphanumeric characters, may contain hyphens, and have a 
    /// valid structure with dots separating the domain labels.
    /// </summary>
    public const string HOST_NAME = @"^(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\\-]*[A-Za-z0-9])$";


    /// <summary>
    /// This regex matches IPv4 addressses ensuring that each octet is a 
    /// valid number between 0 and 255 and that there are three such 
    /// octets separated by dots. 
    /// </summary>
    public const string IPv4_ADDRESS = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";


    /// <summary>
    /// Thie regex validates an email address: non-empty string before the '@' symbol, 
    /// followed by the '@' symbol, then another non-empty string after the '@' symbol, 
    /// followed by a dot '.' and another non-empty string before the end of the address. 
    /// This regex will match most common email address formats, but it may not cover 
    /// all possible variations.
    /// </summary>
    public const string EMAIL_ADDRESS = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
}
