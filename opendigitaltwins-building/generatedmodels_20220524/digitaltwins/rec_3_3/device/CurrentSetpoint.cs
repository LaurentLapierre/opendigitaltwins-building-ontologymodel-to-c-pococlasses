using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class CurrentSetpoint : QuantitySetpoint, IEquatable<CurrentSetpoint>
    {
        public CurrentSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:CurrentSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CurrentSetpoint);
        }

        public bool Equals(CurrentSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CurrentSetpoint? left, CurrentSetpoint? right)
        {
            return EqualityComparer<CurrentSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(CurrentSetpoint? left, CurrentSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}