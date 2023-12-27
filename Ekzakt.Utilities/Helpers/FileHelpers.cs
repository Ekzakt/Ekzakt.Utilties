using System.Text.RegularExpressions;

namespace Ekzakt.Utilities.Helpers;

public class FileHelpers
{
    public static string ConvertToSaveRootName(string fileName)
    {
        var safeName = Path.GetFileNameWithoutExtension(fileName);


        // First trim the raw string.
        safeName = safeName.Trim();


        // Replace spaces with hyphens.
        safeName = safeName.Replace(" ", "-").ToLower();


        // Replace any 'double spaces' with singles.
        if (safeName.IndexOf("--") > -1)
            while (safeName.IndexOf("--") > -1)
                safeName = safeName.Replace("--", "-");


        // Trim out illegal characters.
        safeName = Regex.Replace(safeName, "[^a-z0-9\\-]", "");


        // Trim the length.
        if (safeName.Length > 50)
            safeName = safeName.Substring(0, 49);


        // Clean the beginning and end of the filename.
        char[] replace = { '-', '.' };
        safeName = safeName.TrimStart(replace);
        safeName = safeName.TrimEnd(replace);

        return safeName;
    }
}
