namespace Dedo.Contracts.Exceptions;

public class PaymentLimitExceededException : BaseException
{
    public PaymentLimitExceededException()
        : base("PAYMENT_LIMIT_EXCEEDED", "El monto supera el límite configurado para su cuenta.", 403) { }
}
