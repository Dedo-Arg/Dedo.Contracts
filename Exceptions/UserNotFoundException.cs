namespace Dedo.Contracts.Exceptions;

public class UserNotFoundException : BaseException
{
    public UserNotFoundException(Guid userId)
        : base("USER_NOT_FOUND", $"Usuario {userId} no encontrado.", 404) { }
}
