using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class Bathroom : Room, IEquatable<Bathroom>
    {
        public Bathroom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:Bathroom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Bathroom);
        }

        public bool Equals(Bathroom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Bathroom? left, Bathroom? right)
        {
            return EqualityComparer<Bathroom?>.Default.Equals(left, right);
        }

        public static bool operator !=(Bathroom? left, Bathroom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}