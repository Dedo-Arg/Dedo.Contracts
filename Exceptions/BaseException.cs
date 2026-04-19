namespace Dedo.Contracts.Exceptions;

public abstract class BaseException : Exception
{
    public string ErrorCode  { get; }
    public int    HttpStatus { get; }

    protected BaseException(string errorCode, string message, int httpStatus = 400)
        : base(message)
    {
        ErrorCode  = errorCode;
        HttpStatus = httpStatus;
    }
}
