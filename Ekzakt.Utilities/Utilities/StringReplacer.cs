namespace Ekzakt.Utilities;


public class StringReplacer
{
    private const string PREFIX = "{{";
    private const string SUFFIX = "}}";

    private Dictionary<string, string> _replacements = new();

    public StringReplacer() { }

    public StringReplacer(Dictionary<string, string> replacements)
    {
        _replacements = replacements ?? new();
    }

    [Obsolete("User AddReplacement instead. This method will be removed in a future version.")]
    public void Add(string key, string value)
    {
        _replacements.Add(key, value);
    }

    public void AddReplacements(string key, string value)
    {
        if (_replacements.ContainsKey(key))
        {
            _replacements[key] = value;
            return;
        }

        _replacements.Add(key, value);
    }

    public string Replace(string textToReplaceIn)
    {
        var output = textToReplaceIn;

        foreach (var replacement in _replacements)
        {
            output = textToReplaceIn.Replace(
                oldValue: $"{PREFIX}{replacement.Key}{SUFFIX}",
                newValue: replacement.Value);
        }

        return output;
    }
}
