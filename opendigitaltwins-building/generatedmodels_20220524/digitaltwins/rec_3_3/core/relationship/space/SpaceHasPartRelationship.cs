using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.space
{

    public class SpaceHasPartRelationship : Relationship<Space>, IEquatable<SpaceHasPartRelationship>
    {
        public SpaceHasPartRelationship()
        {
            Name = "hasPart";
        }

        public SpaceHasPartRelationship(Space source, Space target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SpaceHasPartRelationship);
        }

        public bool Equals(SpaceHasPartRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SpaceHasPartRelationship? left, SpaceHasPartRelationship? right)
        {
            return EqualityComparer<SpaceHasPartRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpaceHasPartRelationship? left, SpaceHasPartRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SpaceHasPartRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}