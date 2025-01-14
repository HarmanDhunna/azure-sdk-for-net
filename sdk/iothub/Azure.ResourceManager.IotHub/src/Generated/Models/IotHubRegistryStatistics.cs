// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Identity registry statistics. </summary>
    public partial class IotHubRegistryStatistics
    {
        /// <summary> Initializes a new instance of IotHubRegistryStatistics. </summary>
        internal IotHubRegistryStatistics()
        {
        }

        /// <summary> Initializes a new instance of IotHubRegistryStatistics. </summary>
        /// <param name="totalDeviceCount"> The total count of devices in the identity registry. </param>
        /// <param name="enabledDeviceCount"> The count of enabled devices in the identity registry. </param>
        /// <param name="disabledDeviceCount"> The count of disabled devices in the identity registry. </param>
        internal IotHubRegistryStatistics(long? totalDeviceCount, long? enabledDeviceCount, long? disabledDeviceCount)
        {
            TotalDeviceCount = totalDeviceCount;
            EnabledDeviceCount = enabledDeviceCount;
            DisabledDeviceCount = disabledDeviceCount;
        }

        /// <summary> The total count of devices in the identity registry. </summary>
        public long? TotalDeviceCount { get; }
        /// <summary> The count of enabled devices in the identity registry. </summary>
        public long? EnabledDeviceCount { get; }
        /// <summary> The count of disabled devices in the identity registry. </summary>
        public long? DisabledDeviceCount { get; }
    }
}
