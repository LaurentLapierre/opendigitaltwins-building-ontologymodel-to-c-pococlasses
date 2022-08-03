using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.asset
{

    public class AssetIncludedInRelationship : Relationship<Collection>, IEquatable<AssetIncludedInRelationship>
    {
        public AssetIncludedInRelationship()
        {
            Name = "includedIn";
        }

        public AssetIncludedInRelationship(Asset source, Collection target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as AssetIncludedInRelationship);
        }

        public bool Equals(AssetIncludedInRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(AssetIncludedInRelationship? left, AssetIncludedInRelationship? right)
        {
            return EqualityComparer<AssetIncludedInRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(AssetIncludedInRelationship? left, AssetIncludedInRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as AssetIncludedInRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}