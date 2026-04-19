namespace Dedo.Contracts.DTOs.Requests;

public record ResolveFraudAlertRequest(
    Guid   FraudAlertId,
    Guid   ResolvedBy,
    string ResolutionNotes
);
