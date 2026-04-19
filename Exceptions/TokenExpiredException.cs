namespace Dedo.Contracts.Exceptions;

public class TokenExpiredException : BaseException
{
    public TokenExpiredException()
        : base("TOKEN_EXPIRED", "El token de Mercado Pago ha expirado.", 401) { }
}
