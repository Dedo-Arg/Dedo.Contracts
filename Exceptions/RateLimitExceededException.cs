namespace Dedo.Contracts.Exceptions;

public class RateLimitExceededException : BaseException
{
    public RateLimitExceededException(string endpoint)
        : base("RATE_LIMIT_EXCEEDED", $"Límite de solicitudes superado para {endpoint}. Intente más tarde.", 429) { }
}
