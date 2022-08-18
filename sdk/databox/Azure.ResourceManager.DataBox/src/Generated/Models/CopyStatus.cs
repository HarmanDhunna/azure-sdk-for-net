// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The Status of the copy. </summary>
    public readonly partial struct CopyStatus : IEquatable<CopyStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CopyStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CopyStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string InProgressValue = "InProgress";
        private const string CompletedValue = "Completed";
        private const string CompletedWithErrorsValue = "CompletedWithErrors";
        private const string FailedValue = "Failed";
        private const string NotReturnedValue = "NotReturned";
        private const string HardwareErrorValue = "HardwareError";
        private const string DeviceFormattedValue = "DeviceFormatted";
        private const string DeviceMetadataModifiedValue = "DeviceMetadataModified";
        private const string StorageAccountNotAccessibleValue = "StorageAccountNotAccessible";
        private const string UnsupportedDataValue = "UnsupportedData";
        private const string DriveNotReceivedValue = "DriveNotReceived";
        private const string UnsupportedDriveValue = "UnsupportedDrive";
        private const string OtherServiceErrorValue = "OtherServiceError";
        private const string OtherUserErrorValue = "OtherUserError";
        private const string DriveNotDetectedValue = "DriveNotDetected";
        private const string DriveCorruptedValue = "DriveCorrupted";
        private const string MetadataFilesModifiedOrRemovedValue = "MetadataFilesModifiedOrRemoved";

        /// <summary> Data copy hasn&apos;t started yet. </summary>
        public static CopyStatus NotStarted { get; } = new CopyStatus(NotStartedValue);
        /// <summary> Data copy is in progress. </summary>
        public static CopyStatus InProgress { get; } = new CopyStatus(InProgressValue);
        /// <summary> Data copy completed. </summary>
        public static CopyStatus Completed { get; } = new CopyStatus(CompletedValue);
        /// <summary> Data copy completed with errors. </summary>
        public static CopyStatus CompletedWithErrors { get; } = new CopyStatus(CompletedWithErrorsValue);
        /// <summary> Data copy failed. No data was copied. </summary>
        public static CopyStatus Failed { get; } = new CopyStatus(FailedValue);
        /// <summary> No copy triggered as device was not returned. </summary>
        public static CopyStatus NotReturned { get; } = new CopyStatus(NotReturnedValue);
        /// <summary> The Device has hit hardware issues. </summary>
        public static CopyStatus HardwareError { get; } = new CopyStatus(HardwareErrorValue);
        /// <summary> Data copy failed. The Device was formatted by user. </summary>
        public static CopyStatus DeviceFormatted { get; } = new CopyStatus(DeviceFormattedValue);
        /// <summary> Data copy failed. Device metadata was modified by user. </summary>
        public static CopyStatus DeviceMetadataModified { get; } = new CopyStatus(DeviceMetadataModifiedValue);
        /// <summary> Data copy failed. Storage Account was not accessible during copy. </summary>
        public static CopyStatus StorageAccountNotAccessible { get; } = new CopyStatus(StorageAccountNotAccessibleValue);
        /// <summary> Data copy failed. The Device data content is not supported. </summary>
        public static CopyStatus UnsupportedData { get; } = new CopyStatus(UnsupportedDataValue);
        /// <summary> No copy triggered as device was not received. </summary>
        public static CopyStatus DriveNotReceived { get; } = new CopyStatus(DriveNotReceivedValue);
        /// <summary> No copy triggered as device type is not supported. </summary>
        public static CopyStatus UnsupportedDrive { get; } = new CopyStatus(UnsupportedDriveValue);
        /// <summary> Copy failed due to service error. </summary>
        public static CopyStatus OtherServiceError { get; } = new CopyStatus(OtherServiceErrorValue);
        /// <summary> Copy failed due to user error. </summary>
        public static CopyStatus OtherUserError { get; } = new CopyStatus(OtherUserErrorValue);
        /// <summary> Copy failed due to disk detection error. </summary>
        public static CopyStatus DriveNotDetected { get; } = new CopyStatus(DriveNotDetectedValue);
        /// <summary> Copy failed due to corrupted drive. </summary>
        public static CopyStatus DriveCorrupted { get; } = new CopyStatus(DriveCorruptedValue);
        /// <summary> Copy failed due to modified or removed metadata files. </summary>
        public static CopyStatus MetadataFilesModifiedOrRemoved { get; } = new CopyStatus(MetadataFilesModifiedOrRemovedValue);
        /// <summary> Determines if two <see cref="CopyStatus"/> values are the same. </summary>
        public static bool operator ==(CopyStatus left, CopyStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CopyStatus"/> values are not the same. </summary>
        public static bool operator !=(CopyStatus left, CopyStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CopyStatus"/>. </summary>
        public static implicit operator CopyStatus(string value) => new CopyStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CopyStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CopyStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
