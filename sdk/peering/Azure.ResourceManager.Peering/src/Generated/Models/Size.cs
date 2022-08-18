// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The size of the peering SKU. </summary>
    public readonly partial struct Size : IEquatable<Size>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Size"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Size(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FreeValue = "Free";
        private const string MeteredValue = "Metered";
        private const string UnlimitedValue = "Unlimited";

        /// <summary> Free. </summary>
        public static Size Free { get; } = new Size(FreeValue);
        /// <summary> Metered. </summary>
        public static Size Metered { get; } = new Size(MeteredValue);
        /// <summary> Unlimited. </summary>
        public static Size Unlimited { get; } = new Size(UnlimitedValue);
        /// <summary> Determines if two <see cref="Size"/> values are the same. </summary>
        public static bool operator ==(Size left, Size right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Size"/> values are not the same. </summary>
        public static bool operator !=(Size left, Size right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Size"/>. </summary>
        public static implicit operator Size(string value) => new Size(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Size other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Size other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
