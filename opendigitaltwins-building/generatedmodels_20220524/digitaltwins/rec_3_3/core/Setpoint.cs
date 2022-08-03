using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Setpoint : Parameter, IEquatable<Setpoint>
    {
        public Setpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Setpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Setpoint);
        }

        public bool Equals(Setpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Setpoint? left, Setpoint? right)
        {
            return EqualityComparer<Setpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(Setpoint? left, Setpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}