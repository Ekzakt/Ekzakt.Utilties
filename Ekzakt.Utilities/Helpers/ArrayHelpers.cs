namespace Ekzakt.Core.Helpers;

public class ArrayHelpers
{
    /// <summary>
    /// Gets a random string from an array of strings.
    /// </summary>
    /// <param name="values"></param>
    /// <returns>string</returns>
    public static string GetRandom(string[] values)
    {
        if (!values.Any())
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
}
