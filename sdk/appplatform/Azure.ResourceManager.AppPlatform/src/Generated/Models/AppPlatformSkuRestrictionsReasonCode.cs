// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Gets the reason for restriction. Possible values include: &apos;QuotaId&apos;, &apos;NotAvailableForSubscription&apos;. </summary>
    public readonly partial struct AppPlatformSkuRestrictionsReasonCode : IEquatable<AppPlatformSkuRestrictionsReasonCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppPlatformSkuRestrictionsReasonCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppPlatformSkuRestrictionsReasonCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QuotaIdValue = "QuotaId";
        private const string NotAvailableForSubscriptionValue = "NotAvailableForSubscription";

        /// <summary> QuotaId. </summary>
        public static AppPlatformSkuRestrictionsReasonCode QuotaId { get; } = new AppPlatformSkuRestrictionsReasonCode(QuotaIdValue);
        /// <summary> NotAvailableForSubscription. </summary>
        public static AppPlatformSkuRestrictionsReasonCode NotAvailableForSubscription { get; } = new AppPlatformSkuRestrictionsReasonCode(NotAvailableForSubscriptionValue);
        /// <summary> Determines if two <see cref="AppPlatformSkuRestrictionsReasonCode"/> values are the same. </summary>
        public static bool operator ==(AppPlatformSkuRestrictionsReasonCode left, AppPlatformSkuRestrictionsReasonCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppPlatformSkuRestrictionsReasonCode"/> values are not the same. </summary>
        public static bool operator !=(AppPlatformSkuRestrictionsReasonCode left, AppPlatformSkuRestrictionsReasonCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppPlatformSkuRestrictionsReasonCode"/>. </summary>
        public static implicit operator AppPlatformSkuRestrictionsReasonCode(string value) => new AppPlatformSkuRestrictionsReasonCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppPlatformSkuRestrictionsReasonCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppPlatformSkuRestrictionsReasonCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
