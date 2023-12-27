namespace Ekzakt.Utilities.Helpers;

public static class VersionExtensions
{
    public static string Format(this Version? version)
    {
        return $"{version?.Major}.{version?.Minor}.{version?.Build}.{version?.Revision}";
    }
}
