using System.Reflection;

namespace Ekzakt.Utilities.Helpers;

public static class IntHelpers
{
    /// <summary>
    /// Returns a random value between minValue and maxValue.
    /// </summary>
    /// <param name="minValue">The minimum value, included.</param>
    /// <param name="maxValue">The maximum value, included.</param>
    /// <returns>int</returns>
    public static int GetRandomIntBetween(int minValue, int maxValue)
    {
        int min = minValue > maxValue ? maxValue : minValue;
        int max = maxValue > minValue ? maxValue : minValue;

        Random random = new Random();

        var result = random.Next(min, max);

        return result;
    }


    /// <summary>
    /// Returns a random int value between int.MinValue and int.MaxValue.
    /// </summary>
    /// <returns>int</returns>
    public static int GetRandomInt()
    {
        return GetRandomIntBetween(int.MinValue, int.MaxValue);
    }


    /// <summary>
    /// Returns a random positive int value, zero not included.
    /// </summary>
    /// <returns>int</returns>
    public static int GetRandomPositiveInt()
    {
        return GetRandomIntBetween(1, int.MaxValue);
    }


    /// <summary>
    /// Returns a random negative int value, zero not included.
    /// </summary>
    /// <returns>int</returns>
    public static int GetRandomNegativeInt()
    {
        return GetRandomIntBetween(int.MinValue, -1);
    }
}
