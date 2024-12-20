namespace Ekzakt.Utilities.Helpers;

public static class ArrayHelpers
{
    /// <summary>
    /// Gets a random string from an array of strings.
    /// </summary>
    /// <param name="values"></param>
    /// <returns>string</returns>
    public static string GetRandom(string[] values)
    {
        if (values.Length == 0)
        {
            return string.Empty;
        }

        if (values.Length == 1)
        {
            return values[0];
        }

        Random rand = new Random();

        int index = rand.Next(values.Length);

        return values[index];
    }


    /// <summary>
    /// Returns a single character from a given string.
    /// </summary>
    /// <param name="value">The string of which to return a single value from.</param>
    /// <returns>string</returns>
    public static string GetRandom(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return string.Empty;
        }

        Random rand = new();

        int index = rand.Next(value.Length);

        return value[index].ToString();
    }
}
