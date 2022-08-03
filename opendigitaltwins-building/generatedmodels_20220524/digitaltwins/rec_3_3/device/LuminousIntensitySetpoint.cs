using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LuminousIntensitySetpoint : QuantitySetpoint, IEquatable<LuminousIntensitySetpoint>
    {
        public LuminousIntensitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LuminousIntensitySetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as LuminousIntensitySetpoint);
        }

        public bool Equals(LuminousIntensitySetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(LuminousIntensitySetpoint? left, LuminousIntensitySetpoint? right)
        {
            return EqualityComparer<LuminousIntensitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(LuminousIntensitySetpoint? left, LuminousIntensitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}