using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.furniturecollection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FurnitureCollection : AssetCollection, IEquatable<FurnitureCollection>
    {
        public FurnitureCollection()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FurnitureCollection;1";
        [JsonIgnore]
        public FurnitureCollectionIncludesRelationshipCollection Includes { get; set; } = new FurnitureCollectionIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as FurnitureCollection);
        }

        public bool Equals(FurnitureCollection? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FurnitureCollection? left, FurnitureCollection? right)
        {
            return EqualityComparer<FurnitureCollection?>.Default.Equals(left, right);
        }

        public static bool operator !=(FurnitureCollection? left, FurnitureCollection? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}