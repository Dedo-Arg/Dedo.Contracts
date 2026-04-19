namespace Dedo.Contracts.Exceptions;

public class ValidationException : BaseException
{
    public IReadOnlyDictionary<string, string[]> Errors { get; }

    public ValidationException(IReadOnlyDictionary<string, string[]> errors)
        : base("VALIDATION_ERROR", "La solicitud contiene errores de validación.", 400)
    {
        Errors = errors;
    }
}
