// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Details of the data to be used for importing data to azure. </summary>
    public partial class DataImportDetails
    {
        /// <summary> Initializes a new instance of DataImportDetails. </summary>
        /// <param name="accountDetails">
        /// Account details of the data to be transferred
        /// Please note <see cref="DataAccountDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedDiskDetails"/> and <see cref="StorageAccountDetails"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountDetails"/> is null. </exception>
        public DataImportDetails(DataAccountDetails accountDetails)
        {
            if (accountDetails == null)
            {
                throw new ArgumentNullException(nameof(accountDetails));
            }

            AccountDetails = accountDetails;
        }

        /// <summary> Initializes a new instance of DataImportDetails. </summary>
        /// <param name="accountDetails">
        /// Account details of the data to be transferred
        /// Please note <see cref="DataAccountDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedDiskDetails"/> and <see cref="StorageAccountDetails"/>.
        /// </param>
        /// <param name="logCollectionLevel"> Level of the logs to be collected. </param>
        internal DataImportDetails(DataAccountDetails accountDetails, LogCollectionLevel? logCollectionLevel)
        {
            AccountDetails = accountDetails;
            LogCollectionLevel = logCollectionLevel;
        }

        /// <summary>
        /// Account details of the data to be transferred
        /// Please note <see cref="DataAccountDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedDiskDetails"/> and <see cref="StorageAccountDetails"/>.
        /// </summary>
        public DataAccountDetails AccountDetails { get; set; }
        /// <summary> Level of the logs to be collected. </summary>
        public LogCollectionLevel? LogCollectionLevel { get; set; }
    }
}
