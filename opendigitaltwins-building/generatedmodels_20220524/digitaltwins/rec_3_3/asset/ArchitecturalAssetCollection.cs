using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.architecturalassetcollection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ArchitecturalAssetCollection : AssetCollection, IEquatable<ArchitecturalAssetCollection>
    {
        public ArchitecturalAssetCollection()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ArchitecturalAssetCollection;1";
        [JsonIgnore]
        public ArchitecturalAssetCollectionIncludesRelationshipCollection Includes { get; set; } = new ArchitecturalAssetCollectionIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as ArchitecturalAssetCollection);
        }

        public bool Equals(ArchitecturalAssetCollection? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ArchitecturalAssetCollection? left, ArchitecturalAssetCollection? right)
        {
            return EqualityComparer<ArchitecturalAssetCollection?>.Default.Equals(left, right);
        }

        public static bool operator !=(ArchitecturalAssetCollection? left, ArchitecturalAssetCollection? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}