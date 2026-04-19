namespace Dedo.Contracts.Exceptions;

public class MercadoPagoApiException : BaseException
{
    public MercadoPagoApiException(string detail)
        : base("MP_API_ERROR", $"Error en la API de Mercado Pago: {detail}", 502) { }
}
