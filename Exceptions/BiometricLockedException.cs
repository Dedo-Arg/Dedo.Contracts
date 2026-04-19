namespace Dedo.Contracts.Exceptions;

public class BiometricLockedException : BaseException
{
    public BiometricLockedException(int minutesRemaining)
        : base("BIOMETRIC_LOCKED", $"Cuenta bloqueada por intentos fallidos. Intente en {minutesRemaining} minutos.", 429) { }
}
