namespace Dedo.Contracts.Exceptions;

public class BiometricMatchFailedException : BaseException
{
    public BiometricMatchFailedException()
        : base("BIOMETRIC_NO_MATCH", "La huella no coincide con la registrada.", 401) { }
}
