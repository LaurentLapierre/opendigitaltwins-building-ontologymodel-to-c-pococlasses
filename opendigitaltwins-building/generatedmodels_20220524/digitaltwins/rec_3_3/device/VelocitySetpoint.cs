using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class VelocitySetpoint : QuantitySetpoint, IEquatable<VelocitySetpoint>
    {
        public VelocitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:VelocitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as VelocitySetpoint);
        }

        public bool Equals(VelocitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(VelocitySetpoint? left, VelocitySetpoint? right)
        {
            return EqualityComparer<VelocitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(VelocitySetpoint? left, VelocitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}