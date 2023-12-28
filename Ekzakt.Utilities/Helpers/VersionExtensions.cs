namespace Ekzakt.Utilities.Helpers;

public static class VersionExtensions
{
    /// <summary>
    /// Returns a formatted string with major, minor and build,
    /// and onlyy a revision version when it is not zero.
    /// </summary>
    /// <param name="version"></param>
    /// <returns>string</returns>
    public static string Format(this Version? version)
    {
        var revision = version?.Revision == 0 ? string.Empty : $".{version?.Revision}";

        return $"{version?.Major}.{version?.Minor}.{version?.Build}{revision}";
    }
}
