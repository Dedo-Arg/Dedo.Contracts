namespace Dedo.Contracts.Exceptions;

public class ServiceUnavailableException : BaseException
{
    public ServiceUnavailableException(string service)
        : base("SERVICE_UNAVAILABLE", $"El servicio '{service}' no está disponible temporalmente.", 503) { }
}
