using System.Text.Json.Serialization;
using Dedo.Contracts.DTOs.Events;
using Dedo.Contracts.DTOs.Requests;
using Dedo.Contracts.DTOs.Responses;

namespace Dedo.Contracts.Serialization;

/// <summary>
/// Source-generated JSON serializer context for high-throughput serialization
/// without reflection overhead. Critical for 100K+ TPS scenarios.
/// </summary>
[JsonSourceGenerationOptions(
    PropertyNamingPolicy        = JsonKnownNamingPolicy.CamelCase,
    DefaultIgnoreCondition      = JsonIgnoreCondition.WhenWritingNull,
    WriteIndented               = false,
    UseStringEnumConverter      = true)]

// Events
[JsonSerializable(typeof(AuditEventRequested))]
[JsonSerializable(typeof(BiometricEnrolledEvent))]
[JsonSerializable(typeof(BiometricMatchedEvent))]
[JsonSerializable(typeof(FraudAlertEvent))]
[JsonSerializable(typeof(IdentityVerificationFailedEvent))]
[JsonSerializable(typeof(IdentityVerifiedEvent))]
[JsonSerializable(typeof(NotificationRequestedEvent))]
[JsonSerializable(typeof(PaymentBlockRequestEvent))]
[JsonSerializable(typeof(PaymentProcessedEvent))]
[JsonSerializable(typeof(TokenRefreshedEvent))]
[JsonSerializable(typeof(TokenRefreshRequiredEvent))]
[JsonSerializable(typeof(UserSuspendRequestEvent))]

// Requests
[JsonSerializable(typeof(BiometricValidateRequest))]
[JsonSerializable(typeof(CompleteEnrollmentRequest))]
[JsonSerializable(typeof(CreateUserRequest))]
[JsonSerializable(typeof(EnrollFingerprintRequest))]
[JsonSerializable(typeof(FraudCheckRequest))]
[JsonSerializable(typeof(LoginRequest))]
[JsonSerializable(typeof(MpCreatePaymentRequest))]
[JsonSerializable(typeof(ProcessPaymentRequest))]
[JsonSerializable(typeof(RefreshTokenRequest))]
[JsonSerializable(typeof(RefundPaymentRequest))]
[JsonSerializable(typeof(ResolveFraudAlertRequest))]
[JsonSerializable(typeof(SendNotificationRequest))]
[JsonSerializable(typeof(StartEnrollmentRequest))]
[JsonSerializable(typeof(UpdatePaymentLimitsRequest))]
[JsonSerializable(typeof(VerifyIdentityRequest))]

// Responses
[JsonSerializable(typeof(ApiResponse<object>))]
[JsonSerializable(typeof(AuthTokenResponse))]
[JsonSerializable(typeof(BiometricValidateResponse))]
[JsonSerializable(typeof(CompleteEnrollmentResponse))]
[JsonSerializable(typeof(EnrollFingerprintResponse))]
[JsonSerializable(typeof(FraudAlertResponse))]
[JsonSerializable(typeof(FraudCheckResponse))]
[JsonSerializable(typeof(FraudRuleResult))]
[JsonSerializable(typeof(MpPaymentResponse))]
[JsonSerializable(typeof(ProcessPaymentResponse))]
[JsonSerializable(typeof(StartEnrollmentResponse))]
[JsonSerializable(typeof(TransactionRecord))]
[JsonSerializable(typeof(TransactionSummaryResponse))]
[JsonSerializable(typeof(UserResponse))]
[JsonSerializable(typeof(VerifyIdentityResponse))]
public partial class DedoJsonContext : JsonSerializerContext;
