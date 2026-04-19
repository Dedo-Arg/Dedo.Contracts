namespace Dedo.Contracts.Exceptions;

public class IdentityExpiredException : BaseException
{
    public IdentityExpiredException()
        : base("IDENTITY_EXPIRED", "La verificación de identidad expiró. Por favor re-verifique su identidad.", 403) { }
}
