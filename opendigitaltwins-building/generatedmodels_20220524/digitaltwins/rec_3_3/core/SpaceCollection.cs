using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class SpaceCollection : Collection, IEquatable<SpaceCollection>
    {
        public SpaceCollection()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:SpaceCollection;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SpaceCollection);
        }

        public bool Equals(SpaceCollection? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SpaceCollection? left, SpaceCollection? right)
        {
            return EqualityComparer<SpaceCollection?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpaceCollection? left, SpaceCollection? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}