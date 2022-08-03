using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class IlluminanceSetpoint : QuantitySetpoint, IEquatable<IlluminanceSetpoint>
    {
        public IlluminanceSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:IlluminanceSetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as IlluminanceSetpoint);
        }

        public bool Equals(IlluminanceSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(IlluminanceSetpoint? left, IlluminanceSetpoint? right)
        {
            return EqualityComparer<IlluminanceSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(IlluminanceSetpoint? left, IlluminanceSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}