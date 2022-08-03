using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Bed : Furniture, IEquatable<Bed>
    {
        public Bed()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Bed;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Bed);
        }

        public bool Equals(Bed? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Bed? left, Bed? right)
        {
            return EqualityComparer<Bed?>.Default.Equals(left, right);
        }

        public static bool operator !=(Bed? left, Bed? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}