using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.system
{

    public class SystemIsPartOfRelationship : Relationship<System>, IEquatable<SystemIsPartOfRelationship>
    {
        public SystemIsPartOfRelationship()
        {
            Name = "isPartOf";
        }

        public SystemIsPartOfRelationship(System source, System target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SystemIsPartOfRelationship);
        }

        public bool Equals(SystemIsPartOfRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SystemIsPartOfRelationship? left, SystemIsPartOfRelationship? right)
        {
            return EqualityComparer<SystemIsPartOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SystemIsPartOfRelationship? left, SystemIsPartOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SystemIsPartOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}