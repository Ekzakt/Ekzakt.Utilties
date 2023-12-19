namespace Ekzakt.Core.Contracts;

public abstract class ResultBase
{
    public abstract bool IsSuccess { get; }
    public string Error { get; set; } = string.Empty;
}
