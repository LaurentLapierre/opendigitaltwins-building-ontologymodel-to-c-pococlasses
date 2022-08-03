using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class AccelerationSetpoint : QuantitySetpoint, IEquatable<AccelerationSetpoint>
    {
        public AccelerationSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:AccelerationSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AccelerationSetpoint);
        }

        public bool Equals(AccelerationSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AccelerationSetpoint? left, AccelerationSetpoint? right)
        {
            return EqualityComparer<AccelerationSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(AccelerationSetpoint? left, AccelerationSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}