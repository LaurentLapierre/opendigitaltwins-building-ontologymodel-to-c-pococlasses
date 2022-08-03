using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class VoltageTHDSetpoint : VoltageSetpoint, IEquatable<VoltageTHDSetpoint>
    {
        public VoltageTHDSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:VoltageTHDSetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as VoltageTHDSetpoint);
        }

        public bool Equals(VoltageTHDSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(VoltageTHDSetpoint? left, VoltageTHDSetpoint? right)
        {
            return EqualityComparer<VoltageTHDSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(VoltageTHDSetpoint? left, VoltageTHDSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}