using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.asset
{

    public class AssetServicedByRelationship : Relationship<Agent>, IEquatable<AssetServicedByRelationship>
    {
        public AssetServicedByRelationship()
        {
            Name = "servicedBy";
        }

        public AssetServicedByRelationship(Asset source, Agent target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as AssetServicedByRelationship);
        }

        public bool Equals(AssetServicedByRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(AssetServicedByRelationship? left, AssetServicedByRelationship? right)
        {
            return EqualityComparer<AssetServicedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(AssetServicedByRelationship? left, AssetServicedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as AssetServicedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}