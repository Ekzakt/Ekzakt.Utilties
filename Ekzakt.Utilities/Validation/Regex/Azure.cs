namespace Ekzakt.Utilities.Validation.Regex;

public static class Azure
{
    public static class StorageAccount
    {
        /// <summary>
        /// This regex matches Azure storage account names ensuring the 
        /// length is between 3 and 24 characters with only lowercase letters and numbers.
        /// The storage account name should be globally available.
        /// </summary>
        public const string STORAGE_ACCOUNT_NAME = "^[a-z0-9]{3,24}$";



        /// <summary>
        /// This regex matches Azure blob client names.
        /// See <see href="https://learn.microsoft.com/en-us/rest/api/storageservices/naming-and-referencing-containers--blobs--and-metadata">the
        /// Microsoft documentation</see> for more information.
        /// </summary>
        public const string BLOB_CLIENT_NAME = @"^(?!.*[/\\.]$)(?!.*[\\/.]$)(?!.*[\\/.]{2,})([^\x00-\x1F\x7F\""*+,:;<=>?@\[\\\]^`{|}]|\%[0-9a-fA-F]{2}){1,1024}$";



        /// <summary>
        /// This regex matches Azure storage account container names ensuring the
        /// langth is between 3 and 63 characters long, and starting and ending 
        /// with a letter or number, containing only letters, numbers, and hyphens, 
        /// with hyphens not allowed to be consecutive.
        /// </summary>
        public const string BLOB_CONTAINER_NAME = "^[a-z0-9](?:[a-z0-9]|-(?=[a-z0-9])){1,61}[a-z0-9]$";
    }
}
