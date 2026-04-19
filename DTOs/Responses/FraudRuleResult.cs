using Dedo.Contracts.Enums;

namespace Dedo.Contracts.DTOs.Responses;

public record FraudRuleResult(
    FraudRuleType Rule,
    int           Score,
    string        Reason
);
