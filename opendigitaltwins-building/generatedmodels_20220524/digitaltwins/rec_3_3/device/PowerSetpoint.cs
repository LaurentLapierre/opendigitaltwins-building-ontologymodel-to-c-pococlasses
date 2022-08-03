using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PowerSetpoint : QuantitySetpoint, IEquatable<PowerSetpoint>
    {
        public PowerSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PowerSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PowerSetpoint);
        }

        public bool Equals(PowerSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PowerSetpoint? left, PowerSetpoint? right)
        {
            return EqualityComparer<PowerSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(PowerSetpoint? left, PowerSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}