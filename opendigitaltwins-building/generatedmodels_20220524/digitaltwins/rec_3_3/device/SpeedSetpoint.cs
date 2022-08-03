using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class SpeedSetpoint : QuantitySetpoint, IEquatable<SpeedSetpoint>
    {
        public SpeedSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:SpeedSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SpeedSetpoint);
        }

        public bool Equals(SpeedSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SpeedSetpoint? left, SpeedSetpoint? right)
        {
            return EqualityComparer<SpeedSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpeedSetpoint? left, SpeedSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}