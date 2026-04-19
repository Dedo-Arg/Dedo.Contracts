namespace Dedo.Contracts.DTOs.Requests;

public record MpCreatePaymentRequest(
    decimal Amount,
    string  Currency,
    string  Description,
    string  AccessToken,        // AES-256 descifrado en runtime. NUNCA persiste descifrado.
    string  ExternalReference
);
