namespace Dedo.Contracts.Exceptions;

public class PaymentBlockedByFraudException : BaseException
{
    public PaymentBlockedByFraudException()
        : base("PAYMENT_BLOCKED_FRAUD", "La transacción fue bloqueada por análisis de seguridad.", 403) { }
}
