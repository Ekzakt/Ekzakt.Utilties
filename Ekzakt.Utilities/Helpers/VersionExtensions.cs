namespace Ekzakt.Utilities.Helpers;

public static class VersionExtensions
{
    /// <summary>
    /// Returns a formatted string with major, minor and build 
    /// versions and only the revision version when it is not zero.
    /// </summary>
    /// <param name="version">System.Version class.</param>
    /// <param name="prefix">Any string value that precedes the returned value.</param>
    /// <returns>string</returns>
    public static string Format(this Version? version, string? prefix = "")
    {
        var revision = version?.Revision <= 0 ? string.Empty : $"{version?.Revision}.";

        return $"{prefix}{version?.Major}.{version?.Minor}.{version?.Build}.{revision}".Trim().TrimEnd('.');
    }
}
