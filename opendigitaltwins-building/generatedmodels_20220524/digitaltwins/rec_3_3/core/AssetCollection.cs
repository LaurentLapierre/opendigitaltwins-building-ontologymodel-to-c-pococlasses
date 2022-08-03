using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class AssetCollection : Collection, IEquatable<AssetCollection>
    {
        public AssetCollection()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:AssetCollection;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AssetCollection);
        }

        public bool Equals(AssetCollection? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AssetCollection? left, AssetCollection? right)
        {
            return EqualityComparer<AssetCollection?>.Default.Equals(left, right);
        }

        public static bool operator !=(AssetCollection? left, AssetCollection? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}