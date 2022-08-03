using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.asset
{

    public class AssetHostsRelationship : Relationship<LogicalDevice>, IEquatable<AssetHostsRelationship>
    {
        public AssetHostsRelationship()
        {
            Name = "hosts";
        }

        public AssetHostsRelationship(Asset source, LogicalDevice target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as AssetHostsRelationship);
        }

        public bool Equals(AssetHostsRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(AssetHostsRelationship? left, AssetHostsRelationship? right)
        {
            return EqualityComparer<AssetHostsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(AssetHostsRelationship? left, AssetHostsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as AssetHostsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}