namespace Dedo.Contracts.Enums;

/// <summary>PostgreSQL: fraud_action — acción recomendada por FraudService</summary>
public enum FraudAction
{
    Allow          = 0,
    AllowAndLog    = 1,
    AllowAndNotify = 2,
    Challenge      = 3,
    Block          = 4
}
