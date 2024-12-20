namespace Ekzakt.Utilities.Helpers;

/// <summary>
/// Provides helper methods for string manipulation, including generating random alphanumeric strings,
/// retrieving random characters from a string, and removing duplicate characters from a string.
/// </summary>
public static class StringHelpers
{
    public const string CHARS_NUMERIC = "0123456789";
    public const string CHARS_ALPHABETIC_UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public const string CHARS_ALPHABETIC_LOWER = "abcdefghijklmnopqrstuvwxyz";
    public const string CHARS_ALPHANUMERIC = $"{CHARS_ALPHABETIC_LOWER}{CHARS_ALPHABETIC_UPPER}{CHARS_NUMERIC}";

    /// <summary>
    /// Generates a random alphanumeric string with a specified maximum length.
    /// </summary>
    /// <param name="maxLength">The maximum length of the generated string.</param>
    /// <returns>A random alphanumeric string.</returns>
    public static string GetAlphanumericString(int maxLength)
    {
        int minLength = 1;

        return GetAlphanumericString(minLength, maxLength);
    }

    /// <summary>
    /// Generates a random alphanumeric string with a specified minimum and maximum length.
    /// </summary>
    /// <param name="minLength">The minimum length of the generated string.</param>
    /// <param name="maxLength">The maximum length of the generated string.</param>
    /// <returns>A random alphanumeric string.</returns>
    public static string GetAlphanumericString(int minLength, int maxLength)
    {
        minLength = minLength < 1 ? 1 : minLength;
        maxLength = minLength < 1 ? 1 : maxLength;

        if (minLength > maxLength)
        {
            minLength = maxLength;
        }

        Random rand = new Random();

        var result = Enumerable.Range(minLength, maxLength)
             .Select(x => CHARS_ALPHANUMERIC[rand.Next(0, CHARS_ALPHANUMERIC.Length)]);

        return new string(result.ToArray());
    }

    /// <summary>
    /// Retrieves a random character from the given string.
    /// </summary>
    /// <param name="value">The string to retrieve a random character from.</param>
    /// <returns>A random character from the string.</returns>
    public static string GetRandomChar(this string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return string.Empty;
        }

        Random rand = new();

        int index = rand.Next(value.Length);

        return value[index].ToString();
    }

    /// <summary>
    /// Removes duplicate characters from the given string.
    /// </summary>
    /// <param name="input">The string to remove duplicate characters from.</param>
    /// <returns>A string with duplicate characters removed.</returns>
    public static string RemoveDuplicateChars(this string input)
    {
        return new string(input.Distinct().ToArray());
    }
}
