using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class WallInner : Wall, IEquatable<WallInner>
    {
        public WallInner()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:WallInner;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as WallInner);
        }

        public bool Equals(WallInner? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WallInner? left, WallInner? right)
        {
            return EqualityComparer<WallInner?>.Default.Equals(left, right);
        }

        public static bool operator !=(WallInner? left, WallInner? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}