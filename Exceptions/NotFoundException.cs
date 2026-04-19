namespace Dedo.Contracts.Exceptions;

public class NotFoundException : BaseException
{
    public NotFoundException(string resource, object id)
        : base("NOT_FOUND", $"{resource} con id '{id}' no encontrado.", 404) { }
}
