using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class MagneticFluxSetpoint : QuantitySetpoint, IEquatable<MagneticFluxSetpoint>
    {
        public MagneticFluxSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:MagneticFluxSetpoint;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as MagneticFluxSetpoint);
        }

        public bool Equals(MagneticFluxSetpoint? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(MagneticFluxSetpoint? left, MagneticFluxSetpoint? right)
        {
            return EqualityComparer<MagneticFluxSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(MagneticFluxSetpoint? left, MagneticFluxSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}