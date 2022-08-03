using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Door : BarrierAsset, IEquatable<Door>
    {
        public Door()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Door;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Door);
        }

        public bool Equals(Door? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Door? left, Door? right)
        {
            return EqualityComparer<Door?>.Default.Equals(left, right);
        }

        public static bool operator !=(Door? left, Door? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}