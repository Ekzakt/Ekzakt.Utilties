using Ekzakt.Utilities.Contracts;

namespace Ekzakt.Utilities.Files.FileNameFactory;

public class CreateFileNameResult : ResultBase
{
    public FileName FileName { get; set; } = new();


    public override bool IsSuccess =>
        !string.IsNullOrEmpty(FileName.RootName) &&
        !string.IsNullOrEmpty(FileName.Extension);


    public CreateFileNameResult(string error)
    {
        Error = error;
    }


    public CreateFileNameResult(FileName fileName)
    {
        FileName = fileName;
    }
}
