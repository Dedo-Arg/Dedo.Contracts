namespace Dedo.Contracts.Exceptions;

public class BiometricNotFoundException : BaseException
{
    public BiometricNotFoundException(Guid userId)
        : base("BIOMETRIC_NOT_FOUND", $"No se encontró huella registrada para el usuario {userId}.", 404) { }
}
