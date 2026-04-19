namespace Dedo.Contracts.Exceptions;

public class IdentityVerificationFailedException : BaseException
{
    public IdentityVerificationFailedException(string reason)
        : base("IDENTITY_VERIFICATION_FAILED", reason, 422) { }
}
