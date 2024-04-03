using System.Text.Json;

namespace Ekzakt.Utilities.Helpers;

public static class MemoryHelpers
{
    /// <summary>
    /// This extension method returns a deep copy of the object
    /// by first serializing it, then deserialize. 
    /// Note: this is not the fastest approach because the serialization
    /// can effect performance.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static T DeepCopy<T>(this T obj) where T: class
    {
        var serialized = JsonSerializer.Serialize(obj);

        return JsonSerializer.Deserialize<T>(serialized);
    }
}
