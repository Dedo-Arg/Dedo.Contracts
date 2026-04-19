namespace Dedo.Contracts.Constants;

public static class AppConstants
{
    public static class Biometric
    {
        public const string HashAlgorithm     = "SHA-256";
        public const double MatchThreshold    = 0.95;
        public const int    MaxFailedAttempts = 3;
        public const int    LockoutMinutes    = 15;
    }

    public static class Payment
    {
        public const int     TargetProcessingMs = 500;
        public const decimal MinAmount          = 1m;
        public const decimal DefaultMaxAmount   = 50_000m;
        public const string  Currency           = "ARS";
    }

    public static class MercadoPago
    {
        public const int    TokenRenewalThresholdMinutes = 30;
        public const int    AccessTokenExpiryHours       = 6;
        public const string ApiBaseUrl                   = "https://api.mercadopago.com";
    }

    public static class Identity
    {
        public const int VerificationValidYears = 2;
        public const int ExpirationWarningDays  = 30;
    }

    public static class Auth
    {
        public const int AccessTokenExpiryMinutes = 15;
        public const int RefreshTokenExpiryDays   = 7;
    }

    public static class Fraud
    {
        public const int AllowMaxScore     = 30;
        public const int NotifyMinScore    = 51;
        public const int ChallengeMinScore = 71;
        public const int BlockMinScore     = 91;
        public const int MaxProcessingMs   = 50;
    }

    public static class CacheKeys
    {
        public static string UserBiometric(Guid userId)    => $"bio:{userId}";
        public static string UserVerification(Guid userId) => $"verif:{userId}";
        public static string MpToken(Guid userId)          => $"mptoken:{userId}";
        public static string UserLockout(Guid userId)      => $"lockout:{userId}";
        public static string PaymentSession(string id)     => $"paysess:{id}";
        public static string FraudProfile(Guid userId)     => $"fraud:profile:{userId}";
        public static string FraudVelocity(Guid userId)    => $"fraud:velocity:{userId}";
        public static string FraudDeviceUsers(string dev)  => $"fraud:device:{dev}:users";
        public static string FraudMerchant(string mid)     => $"fraud:merchant:{mid}";
    }

    public static class Messaging
    {
        public const string Exchange = "dedo.exchange";

        public static class Queues
        {
            public const string PaymentProcessed      = "dedo.payment.processed";
            public const string PaymentBlockRequest    = "dedo.payment.block.request";
            public const string BiometricEnrolled      = "dedo.biometric.enrolled";
            public const string BiometricMatched       = "dedo.biometric.matched";
            public const string IdentityVerified       = "dedo.identity.verified";
            public const string NotificationRequested  = "dedo.notification.requested";
            public const string AuditEvent             = "dedo.audit.event";
            public const string TokenRefreshRequired   = "dedo.token.refresh.required";
            public const string FraudAlert             = "dedo.fraud.alert";
            public const string UserSuspendRequest     = "dedo.user.suspend.request";
        }
    }

    public static class Encryption
    {
        public const string Algorithm = "AES-256-GCM";
    }
}
