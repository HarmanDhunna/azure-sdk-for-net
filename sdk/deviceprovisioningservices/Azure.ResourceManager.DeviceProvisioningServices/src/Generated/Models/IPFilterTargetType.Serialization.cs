// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    internal static partial class IPFilterTargetTypeExtensions
    {
        public static string ToSerialString(this IPFilterTargetType value) => value switch
        {
            IPFilterTargetType.All => "all",
            IPFilterTargetType.ServiceApi => "serviceApi",
            IPFilterTargetType.DeviceApi => "deviceApi",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IPFilterTargetType value.")
        };

        public static IPFilterTargetType ToIPFilterTargetType(this string value)
        {
            if (string.Equals(value, "all", StringComparison.InvariantCultureIgnoreCase)) return IPFilterTargetType.All;
            if (string.Equals(value, "serviceApi", StringComparison.InvariantCultureIgnoreCase)) return IPFilterTargetType.ServiceApi;
            if (string.Equals(value, "deviceApi", StringComparison.InvariantCultureIgnoreCase)) return IPFilterTargetType.DeviceApi;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IPFilterTargetType value.");
        }
    }
}
