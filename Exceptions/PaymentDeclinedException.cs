namespace Dedo.Contracts.Exceptions;

public class PaymentDeclinedException : BaseException
{
    public string? MpErrorCode { get; }

    public PaymentDeclinedException(string reason, string? mpErrorCode = null)
        : base("PAYMENT_DECLINED", reason, 422)
    {
        MpErrorCode = mpErrorCode;
    }
}
