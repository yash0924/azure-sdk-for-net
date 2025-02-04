// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> Gets or sets the status of the operation. </summary>
    public readonly partial struct OperationStatus : IEquatable<OperationStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="OperationStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "notStarted";
        private const string RunningValue = "running";
        private const string CompletedValue = "completed";
        private const string FailedValue = "failed";

        /// <summary> notStarted. </summary>
        public static OperationStatus NotStarted { get; } = new OperationStatus(NotStartedValue);
        /// <summary> running. </summary>
        public static OperationStatus Running { get; } = new OperationStatus(RunningValue);
        /// <summary> completed. </summary>
        public static OperationStatus Completed { get; } = new OperationStatus(CompletedValue);
        /// <summary> failed. </summary>
        public static OperationStatus Failed { get; } = new OperationStatus(FailedValue);
        /// <summary> Determines if two <see cref="OperationStatus"/> values are the same. </summary>
        public static bool operator ==(OperationStatus left, OperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationStatus"/> values are not the same. </summary>
        public static bool operator !=(OperationStatus left, OperationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationStatus"/>. </summary>
        public static implicit operator OperationStatus(string value) => new OperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
