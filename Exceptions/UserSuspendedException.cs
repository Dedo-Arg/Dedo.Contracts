namespace Dedo.Contracts.Exceptions;

public class UserSuspendedException : BaseException
{
    public UserSuspendedException()
        : base("USER_SUSPENDED", "La cuenta del usuario está suspendida.", 403) { }
}
