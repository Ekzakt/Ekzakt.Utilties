using System.Reflection;

namespace Ekzakt.Utilities.Helpers;

public static class AssemblyExtentions
{
    [Obsolete("Use VersionExtensions instead.")]
    public static string? GetVersionFormattedString(this Assembly assembly)
    {
        var buildVersion = assembly.GetName().Version;

        return $"{buildVersion?.Major}.{buildVersion?.Minor}.{buildVersion?.Build}";
    }
}
