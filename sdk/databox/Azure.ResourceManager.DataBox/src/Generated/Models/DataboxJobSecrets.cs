// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The secrets related to a databox job. </summary>
    public partial class DataboxJobSecrets : JobSecrets
    {
        /// <summary> Initializes a new instance of DataboxJobSecrets. </summary>
        internal DataboxJobSecrets()
        {
            PodSecrets = new ChangeTrackingList<DataBoxSecret>();
            JobSecretsType = ClassDiscriminator.DataBox;
        }

        /// <summary> Initializes a new instance of DataboxJobSecrets. </summary>
        /// <param name="jobSecretsType"> Used to indicate what type of job secrets object. </param>
        /// <param name="dcAccessSecurityCode"> Dc Access Security Code for Customer Managed Shipping. </param>
        /// <param name="error"> Error while fetching the secrets. </param>
        /// <param name="podSecrets"> Contains the list of secret objects for a job. </param>
        internal DataboxJobSecrets(ClassDiscriminator jobSecretsType, DcAccessSecurityCode dcAccessSecurityCode, ResponseError error, IReadOnlyList<DataBoxSecret> podSecrets) : base(jobSecretsType, dcAccessSecurityCode, error)
        {
            PodSecrets = podSecrets;
            JobSecretsType = jobSecretsType;
        }

        /// <summary> Contains the list of secret objects for a job. </summary>
        public IReadOnlyList<DataBoxSecret> PodSecrets { get; }
    }
}
