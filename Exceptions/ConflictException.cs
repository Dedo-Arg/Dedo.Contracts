namespace Dedo.Contracts.Exceptions;

public class ConflictException : BaseException
{
    public ConflictException(string message)
        : base("CONFLICT", message, 409) { }
}
