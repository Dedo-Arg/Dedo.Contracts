namespace Dedo.Contracts.Enums;

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
