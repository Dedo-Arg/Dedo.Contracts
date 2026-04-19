using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Responses;

public record FraudAlertResponse(
    Guid      AlertId,
    Guid      PaymentId,
    Guid      UserId,
    int       RiskScore,
    RiskLevel RiskLevel,
    bool      Resolved,
    DateTime  CreatedAt
);
