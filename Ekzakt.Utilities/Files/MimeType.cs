namespace Ekzakt.Core.Files;

public class MimeType
{
    public virtual string FileType { get; init; } = string.Empty;
    public virtual string Value { get; init; } = string.Empty;
    public virtual string FileExtension { get; init;} = string.Empty;


    public MimeType() { }


    public MimeType(string fileType, string name, string fileExtension)
    {
        FileType = fileType ?? throw new ArgumentNullException(nameof(FileType));
        Value = name ?? throw new ArgumentNullException(nameof(Value));
        FileExtension = fileExtension ?? throw new ArgumentNullException(nameof(FileExtension));
    }
}
