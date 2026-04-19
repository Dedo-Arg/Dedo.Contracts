namespace Dedo.Contracts.DTOs.Requests;

public record RefundPaymentRequest(
    Guid     TransactionId,
    decimal? Amount = null,
    string?  Reason = null
);
