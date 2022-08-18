// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The result returned from a database check name availability request. </summary>
    public partial class CheckNameContent
    {
        /// <summary> Initializes a new instance of CheckNameContent. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="kustoResourceType"> The type of resource, for instance Microsoft.Kusto/clusters/databases. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public CheckNameContent(string name, KustoResourceType kustoResourceType)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            KustoResourceType = kustoResourceType;
        }

        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, for instance Microsoft.Kusto/clusters/databases. </summary>
        public KustoResourceType KustoResourceType { get; }
    }
}
