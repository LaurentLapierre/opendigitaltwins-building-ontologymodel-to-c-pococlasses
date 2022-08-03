using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.furniturecollection
{

    public class FurnitureCollectionIncludesRelationship : Relationship<Furniture>, IEquatable<FurnitureCollectionIncludesRelationship>
    {
        public FurnitureCollectionIncludesRelationship()
        {
            Name = "includes";
        }

        public FurnitureCollectionIncludesRelationship(FurnitureCollection source, Furniture target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as FurnitureCollectionIncludesRelationship);
        }

        public bool Equals(FurnitureCollectionIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(FurnitureCollectionIncludesRelationship? left, FurnitureCollectionIncludesRelationship? right)
        {
            return EqualityComparer<FurnitureCollectionIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(FurnitureCollectionIncludesRelationship? left, FurnitureCollectionIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as FurnitureCollectionIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}