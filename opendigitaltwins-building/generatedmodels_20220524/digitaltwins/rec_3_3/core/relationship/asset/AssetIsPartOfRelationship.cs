using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.asset
{

    public class AssetIsPartOfRelationship : Relationship<Asset>, IEquatable<AssetIsPartOfRelationship>
    {
        public AssetIsPartOfRelationship()
        {
            Name = "isPartOf";
        }

        public AssetIsPartOfRelationship(Asset source, Asset target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as AssetIsPartOfRelationship);
        }

        public bool Equals(AssetIsPartOfRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(AssetIsPartOfRelationship? left, AssetIsPartOfRelationship? right)
        {
            return EqualityComparer<AssetIsPartOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(AssetIsPartOfRelationship? left, AssetIsPartOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as AssetIsPartOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}