namespace Ekzakt.Utilities.Extentions;

public static class LongExtensions
{
    /// <summary>
    /// Formats the given file size (long) in bytes into a human-readable 
    /// string representation with the appropriate unit (Bytes, KB, MB, GB, TB, PB, EB, ZB, YB).
    /// </summary>
    [Obsolete("Use overload FormatFileSize(int decimalPlaces = 0) instead.")]
    public static string FormatFileSize(this long value)
    {
        return value.FormatFileSize(0);
    }


    /// <summary>
    /// Formats the specified file size value into a human-readable string representation.
    /// </summary>
    /// <param name="value">The file size value to format.</param>
    /// <param name="decimalPlaces">The number of decimal places to include in the formatted string. Default is 0.</param>
    /// <returns>A string representing the formatted file size.</returns>
    public static string FormatFileSize(this long value, int decimalPlaces = 0)
    {
        var bytes = (decimal)value;

        string[] sizeSuffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        const int scale = 1024;

        int order = 0;
        while (bytes >= scale && order < sizeSuffixes.Length - 1)
        {
            bytes /= scale;
            order++;
        }

        string formatString = $"{{0:N{decimalPlaces}}} {{1}}";
        return string.Format(formatString, bytes, sizeSuffixes[order]);
    }
}
