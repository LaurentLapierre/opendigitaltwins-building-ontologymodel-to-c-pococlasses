using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class Pantry : FoodHandlingRoom, IEquatable<Pantry>
    {
        public Pantry()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:Pantry;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Pantry);
        }

        public bool Equals(Pantry? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Pantry? left, Pantry? right)
        {
            return EqualityComparer<Pantry?>.Default.Equals(left, right);
        }

        public static bool operator !=(Pantry? left, Pantry? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}