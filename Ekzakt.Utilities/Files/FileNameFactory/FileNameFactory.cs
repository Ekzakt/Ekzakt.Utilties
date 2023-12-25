namespace Ekzakt.Core.Files.FileNameFactory;

public class FileNameFactory : IFileNameFactory
{
    public CreateFileNameResult CreateFileName(string originalFileName, string contentType, Action<FileNameFactoryOptions>? options = null)
    {
        var opt = new FileNameFactoryOptions();

        if (options is not null)
        {
            options(opt);
        }


        if (string.IsNullOrEmpty(originalFileName))
        {
            throw new ArgumentNullException(nameof(originalFileName));
        }


        if (string.IsNullOrEmpty(contentType))
        {
            throw new ArgumentNullException($"{nameof(contentType)}");
        }


        var mimeType = GetMimeType(contentType, opt.PermittedMimeTypes);

        if (mimeType == null)
        {
            throw new InvalidOperationException($"Mimetype {contentType} is not valid to be used.");
        }


        var fileName = new FileName(
            prefix: GetPrefixOrSuffix(opt.Prefix, opt.GenerateRandomPrefix, opt.RandomPrefixMinLength, opt.RandomPrefixMaxLength),
            rootName: GetRootName(originalFileName, opt.DoNotUseGuidAsRootName),
            extension: mimeType.FileExtension,
            suffix: GetPrefixOrSuffix(opt.Suffix, opt.GenerateRandomSuffix, opt.RandomSuffixMinLength, opt.RandomSuffixMaxLength)
        );

        return new CreateFileNameResult(fileName);
    }



    #region Helpers

    private MimeType? GetMimeType(string contentType, MimeType[] permittedMimeTypes)
    {
        if (!permittedMimeTypes.Any())
        {
            return null;
        }

        var output = permittedMimeTypes
            .Where(x => x.Value == contentType)
            .FirstOrDefault();

        return output;
    }


    private string GetRootName(string fileName, bool doNotUseGuid)
    {
        var root = Path.GetFileNameWithoutExtension(fileName);

        return !doNotUseGuid
            ? Guid.NewGuid().ToString().ToLower()
            : Helpers.FileHelpers.ConvertToSaveRootName(fileName);
    }


    private string GetPrefixOrSuffix(string currentValue, bool generateRandomValue, byte minLength, byte maxLength)
    {
        if (string.IsNullOrEmpty(currentValue) && generateRandomValue)
        {
            return Helpers.StringHelpers.GetAlphanumericString(minLength, maxLength);
        }

        return currentValue;
    }

    #endregion
}
