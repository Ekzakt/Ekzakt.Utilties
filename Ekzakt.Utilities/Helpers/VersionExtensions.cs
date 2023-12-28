namespace Ekzakt.Utilities.Helpers;

public static class VersionExtensions
{
    public static string Format(this Version? version)
    {
        var revision = version?.Revision == 0 ? $".{version?.Revision}" : string.Empty;

        return $"{version?.Major}.{version?.Minor}.{version?.Build}{revision}";
    }
}
