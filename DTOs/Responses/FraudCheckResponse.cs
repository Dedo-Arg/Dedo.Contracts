using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Responses;

public record FraudCheckResponse(
    Guid                  FraudCheckId,
    int                   RiskScore,
    RiskLevel             RiskLevel,
    FraudAction           RecommendedAction,
    List<FraudRuleResult> RuleResults,
    DateTime              EvaluatedAt,
    int                   ProcessingTimeMs
);
