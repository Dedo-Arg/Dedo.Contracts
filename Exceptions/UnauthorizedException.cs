namespace Dedo.Contracts.Exceptions;

public class UnauthorizedException : BaseException
{
    public UnauthorizedException(string message = "No autorizado.")
        : base("UNAUTHORIZED", message, 401) { }
}
