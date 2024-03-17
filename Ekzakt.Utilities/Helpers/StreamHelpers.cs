namespace Ekzakt.Utilities.Helpers;

public static class StreamHelpers
{
    /// <summary>
    /// Converts any string into a stream.  
    /// Note: Don't forget to use using.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Stream</returns>
    public static Stream GenerateStreamFromString(string value)
    {
        var stream = new MemoryStream();
        var writer = new StreamWriter(stream);

        writer.Write(value);
        writer.Flush();

        stream.Position = 0;

        return stream;
    }
}
