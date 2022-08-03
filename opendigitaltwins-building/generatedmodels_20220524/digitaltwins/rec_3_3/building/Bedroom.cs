using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class Bedroom : Room, IEquatable<Bedroom>
    {
        public Bedroom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:Bedroom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Bedroom);
        }

        public bool Equals(Bedroom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Bedroom? left, Bedroom? right)
        {
            return EqualityComparer<Bedroom?>.Default.Equals(left, right);
        }

        public static bool operator !=(Bedroom? left, Bedroom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}