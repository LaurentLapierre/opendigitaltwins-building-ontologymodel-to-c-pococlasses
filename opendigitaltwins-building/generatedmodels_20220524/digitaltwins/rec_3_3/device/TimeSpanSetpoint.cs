using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class TimeSpanSetpoint : QuantitySetpoint, IEquatable<TimeSpanSetpoint>
    {
        public TimeSpanSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:TimeSpanSetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as TimeSpanSetpoint);
        }

        public bool Equals(TimeSpanSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(TimeSpanSetpoint? left, TimeSpanSetpoint? right)
        {
            return EqualityComparer<TimeSpanSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(TimeSpanSetpoint? left, TimeSpanSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}