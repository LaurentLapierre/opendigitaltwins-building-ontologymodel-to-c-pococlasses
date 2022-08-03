using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Furniture : Asset, IEquatable<Furniture>
    {
        public Furniture()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Furniture;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Furniture);
        }

        public bool Equals(Furniture? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Furniture? left, Furniture? right)
        {
            return EqualityComparer<Furniture?>.Default.Equals(left, right);
        }

        public static bool operator !=(Furniture? left, Furniture? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}