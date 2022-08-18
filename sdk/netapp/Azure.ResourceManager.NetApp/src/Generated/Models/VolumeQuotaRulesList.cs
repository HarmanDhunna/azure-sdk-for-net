// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> List of Volume Quota Rules. </summary>
    internal partial class VolumeQuotaRulesList
    {
        /// <summary> Initializes a new instance of VolumeQuotaRulesList. </summary>
        internal VolumeQuotaRulesList()
        {
            Value = new ChangeTrackingList<VolumeQuotaRuleData>();
        }

        /// <summary> Initializes a new instance of VolumeQuotaRulesList. </summary>
        /// <param name="value"> A list of Volume Quota Rules. </param>
        internal VolumeQuotaRulesList(IReadOnlyList<VolumeQuotaRuleData> value)
        {
            Value = value;
        }

        /// <summary> A list of Volume Quota Rules. </summary>
        public IReadOnlyList<VolumeQuotaRuleData> Value { get; }
    }
}
