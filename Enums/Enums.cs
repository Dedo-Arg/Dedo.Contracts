namespace Dedo.Contracts.Enums;

// REGLA: NUNCA usar strings para estados. Solo Enums mapeados a PostgreSQL ENUM types.

/// <summary>PostgreSQL: verification_status</summary>
public enum VerificationStatus
{
    Pending   = 0,
    Verified  = 1,
    Expired   = 2,
    Rejected  = 3,
    Suspended = 4
}

/// <summary>PostgreSQL: payment_status</summary>
public enum PaymentStatus
{
    Pending             = 0,
    Approved            = 1,
    Rejected            = 2,
    Refunded            = 3,
    PendingConfirmation = 4
}

/// <summary>PostgreSQL: token_status</summary>
public enum TokenStatus
{
    Active       = 0,
    ExpiringSoon = 1,
    Expired      = 2,
    Revoked      = 3
}

/// <summary>PostgreSQL: operation_status</summary>
public enum OperationStatus
{
    Success      = 0,
    Failed       = 1,
    PendingRetry = 2,
    Cancelled    = 3
}

/// <summary>PostgreSQL: biometric_match_result</summary>
public enum BiometricMatchResult
{
    Match   = 0,
    NoMatch = 1,
    Failed  = 2,
    Error   = 3
}

/// <summary>PostgreSQL: audit_event_type</summary>
public enum AuditEventType
{
    IdentityVerificationStarted   = 100,
    IdentityVerificationCompleted = 101,
    IdentityVerificationFailed    = 102,
    EnrollmentStarted             = 200,
    EnrollmentCompleted           = 201,
    EnrollmentFailed              = 202,
    BiometricMatchAttempted       = 300,
    BiometricMatchSuccess         = 301,
    BiometricMatchFailed          = 302,
    PaymentInitiated              = 400,
    PaymentApproved               = 401,
    PaymentRejected               = 402,
    PaymentRefunded               = 403,
    TokenIssued                   = 500,
    TokenRefreshed                = 501,
    TokenRevoked                  = 502,
    FraudAlertRaised              = 600,
    FraudPaymentBlocked           = 601,
    FraudAlertResolved            = 602,
    SuspiciousActivityDetected    = 900,
    AccountSuspended              = 901
}

/// <summary>PostgreSQL: notification_channel</summary>
public enum NotificationChannel
{
    Push    = 0,
    Sms     = 1,
    Webhook = 2,
    Email   = 3
}

/// <summary>PostgreSQL: user_role</summary>
public enum UserRole
{
    Consumer = 0,
    Merchant = 1,
    Admin    = 2
}

/// <summary>PostgreSQL: risk_level — usado por FraudService</summary>
public enum RiskLevel
{
    Low      = 0,
    Moderate = 1,
    High     = 2,
    VeryHigh = 3,
    Critical = 4
}

/// <summary>PostgreSQL: fraud_action — acción recomendada por FraudService</summary>
public enum FraudAction
{
    Allow          = 0,
    AllowAndLog    = 1,
    AllowAndNotify = 2,
    Challenge      = 3,
    Block          = 4
}

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
