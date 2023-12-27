namespace Ekzakt.Utilities.Files;

public class FileName
{
    /// <summary>
    /// Sets any prefix or suffix to the filename.  If set, the
    /// prefix, rootname and suffix are separated by the Separator
    /// variable.
    /// </summary>
    /// 
    public string Prefix { get; init; } = string.Empty;
    public string RootName { get; init; } = string.Empty;
    public string Suffix { get; init; } = string.Empty;
    public string Extension { get; init; } = string.Empty;
    public string Separator { get; init; } = "-";


    public FileName() { }


    public FileName(string rootName, string extension, string? separarator = null)
    {
        ValidateProperties(rootName, extension);

        RootName = rootName;
        Extension = GetValidExtension(extension);
        Separator = separarator ?? Separator;
    }


    public FileName(string prefix, string rootName, string extension, string? separarator = null)
    {
        ValidateProperties(rootName, extension);

        Prefix = prefix;
        RootName = rootName;
        Extension = GetValidExtension(extension);
        Separator = separarator ?? Separator;
    }


    public FileName(string prefix, string rootName, string suffix, string extension, string? separarator = null)
    {
        ValidateProperties(rootName, extension);

        Prefix = prefix;
        RootName = rootName;
        Suffix = suffix;
        Extension = GetValidExtension(extension);
        Separator = separarator ?? Separator;
    }


    public override string ToString()
    {
        return $"" +
            $"{Prefix}" +
            $"{(string.IsNullOrEmpty(Prefix) ? "" : Separator)}" +
            $"{RootName}" +
            $"{(string.IsNullOrEmpty(Suffix) ? "" : Separator)}" +
            $".{Extension}";
    }


    #region Helpers

    private void ValidateProperties(string rootName, string extension)
    {
        if (string.IsNullOrEmpty(rootName)) throw new ArgumentNullException(nameof(rootName));
        if (string.IsNullOrEmpty(extension)) throw new ArgumentNullException(nameof(extension));
    }


    private string GetValidExtension(string extension)
    {
        var output = extension.StartsWith('.')
            ? extension.Substring(1)
            : extension;

        return output;
    }

    #endregion Helpers
}
