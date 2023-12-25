namespace Ekzakt.Core.Files.FileNameFactory;

public class FileNameFactoryOptions
{
    public MimeType[] PermittedMimeTypes { get; set; } = Array.Empty<MimeType>();
    public string Prefix { get; set; } = string.Empty;
    public string Suffix { get; set; } = string.Empty;
    public bool DoNotUseGuidAsRootName { get; set; }
    public bool GenerateRandomPrefix { get; set; }
    public byte RandomPrefixMinLength { get; set; } = 5;
    public byte RandomPrefixMaxLength { get; set; } = 5;
    public bool GenerateRandomSuffix { get; set; }
    public byte RandomSuffixMinLength { get; set; } = 5;
    public byte RandomSuffixMaxLength { get; set; } = 5;
    public string Separator { get; set; } = "-";
}
