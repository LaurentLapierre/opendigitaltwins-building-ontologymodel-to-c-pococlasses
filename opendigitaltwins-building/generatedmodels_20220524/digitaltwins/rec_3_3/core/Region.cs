using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Region : Space, IEquatable<Region>
    {
        public Region()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Region;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Region);
        }

        public bool Equals(Region? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Region? left, Region? right)
        {
            return EqualityComparer<Region?>.Default.Equals(left, right);
        }

        public static bool operator !=(Region? left, Region? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}