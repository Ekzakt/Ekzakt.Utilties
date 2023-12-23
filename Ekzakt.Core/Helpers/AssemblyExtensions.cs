using System.Reflection;

namespace Ekzakt.Core.Helpers;

public static class AssemblyExtentions
{
    public static string? GetVersionFormattedString(this Assembly assembly)
    {
        var buildVersion = assembly.GetName().Version;

        return $"{buildVersion?.Major}.{buildVersion?.Minor}.{buildVersion?.Build}";
    }
}
