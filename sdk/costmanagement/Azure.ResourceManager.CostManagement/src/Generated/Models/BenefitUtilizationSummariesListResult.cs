// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> List of benefit utilization summaries. </summary>
    internal partial class BenefitUtilizationSummariesListResult
    {
        /// <summary> Initializes a new instance of BenefitUtilizationSummariesListResult. </summary>
        internal BenefitUtilizationSummariesListResult()
        {
            Value = new ChangeTrackingList<BenefitUtilizationSummary>();
        }

        /// <summary> Initializes a new instance of BenefitUtilizationSummariesListResult. </summary>
        /// <param name="value">
        /// The list of benefit utilization summaries.
        /// Please note <see cref="BenefitUtilizationSummary"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="IncludedQuantityUtilizationSummary"/> and <see cref="SavingsPlanUtilizationSummary"/>.
        /// </param>
        /// <param name="nextLink"> The link (URL) to the next page of results. </param>
        internal BenefitUtilizationSummariesListResult(IReadOnlyList<BenefitUtilizationSummary> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// The list of benefit utilization summaries.
        /// Please note <see cref="BenefitUtilizationSummary"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="IncludedQuantityUtilizationSummary"/> and <see cref="SavingsPlanUtilizationSummary"/>.
        /// </summary>
        public IReadOnlyList<BenefitUtilizationSummary> Value { get; }
        /// <summary> The link (URL) to the next page of results. </summary>
        public Uri NextLink { get; }
    }
}
