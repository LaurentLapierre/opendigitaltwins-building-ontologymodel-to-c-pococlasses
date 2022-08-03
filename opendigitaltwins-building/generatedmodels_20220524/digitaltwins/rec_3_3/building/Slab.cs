using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class Slab : BuildingComponent, IEquatable<Slab>
    {
        public Slab()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:Slab;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Slab);
        }

        public bool Equals(Slab? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Slab? left, Slab? right)
        {
            return EqualityComparer<Slab?>.Default.Equals(left, right);
        }

        public static bool operator !=(Slab? left, Slab? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}