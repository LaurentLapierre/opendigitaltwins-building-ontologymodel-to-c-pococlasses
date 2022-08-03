using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class TimeSetpoint : QuantitySetpoint, IEquatable<TimeSetpoint>
    {
        public TimeSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:TimeSetpoint;1";
        [JsonPropertyName("lastValue")]
        public DateTime? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as TimeSetpoint);
        }

        public bool Equals(TimeSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(TimeSetpoint? left, TimeSetpoint? right)
        {
            return EqualityComparer<TimeSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(TimeSetpoint? left, TimeSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}