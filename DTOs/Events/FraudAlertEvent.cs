using Dedo.Contracts.DTOs.Responses;
using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Events;

public record FraudAlertEvent(
    Guid                  FraudAlertId,
    Guid                  PaymentId,
    Guid                  UserId,
    int                   RiskScore,
    RiskLevel             RiskLevel,
    FraudAction           Action,
    List<FraudRuleResult> RuleResults,
    DateTime              DetectedAt
) : BaseEvent;
