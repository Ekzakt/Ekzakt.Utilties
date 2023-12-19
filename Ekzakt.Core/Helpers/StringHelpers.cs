namespace Ekzakt.Core.Helpers;

public class StringHelpers
{
    public const string CHARS_NUMERIC = "0123456789";
    public const string CHARS_ALPHABETIC_UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public const string CHARS_ALPHABETIC_LOWER = "abcdefghijklmnopqrstuvwxyz";
    public const string CHARS_ALPHANUMERIC = $"{CHARS_ALPHABETIC_LOWER}{CHARS_ALPHABETIC_UPPER}{CHARS_NUMERIC}";

    public static string GetAlphanumericString(int maxLength)
    {
        int minLength = 1;

        return GetAlphanumericString(minLength, maxLength);
    }


    public static string GetAlphanumericString(int minLength, int maxLength)
    {
        if (minLength < 0) { minLength = 1; }
        if (maxLength < 0) { maxLength = 1; }

        if (minLength > maxLength)
        {
            minLength = maxLength;
        }

        Random rand = new Random();

        var result = Enumerable.Range(minLength, maxLength)
             .Select(x => CHARS_ALPHANUMERIC[rand.Next(0, CHARS_ALPHANUMERIC.Length)]);

        return new string(result.ToArray());
    }
}
