namespace Ekzakt.Utilities.Extensions;

public static class LongExsensions
{
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
