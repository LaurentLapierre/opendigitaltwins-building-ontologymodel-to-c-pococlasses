using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class QuantitySetpoint : Setpoint, IEquatable<QuantitySetpoint>
    {
        public QuantitySetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:QuantitySetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as QuantitySetpoint);
        }

        public bool Equals(QuantitySetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(QuantitySetpoint? left, QuantitySetpoint? right)
        {
            return EqualityComparer<QuantitySetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(QuantitySetpoint? left, QuantitySetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}