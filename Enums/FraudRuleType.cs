namespace Dedo.Contracts.Enums;

/// <summary>PostgreSQL: fraud_rule_type — tipo de regla ejecutada</summary>
public enum FraudRuleType
{
    Velocity      = 0,
    AmountAnomaly = 1,
    GeoLocation   = 2,
    TimePattern   = 3,
    Device        = 4,
    Merchant      = 5,
    MlModel       = 6
}
