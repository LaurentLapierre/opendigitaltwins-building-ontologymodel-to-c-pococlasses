using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.space
{

    public class SpaceArchitectedByRelationship : Relationship<Agent>, IEquatable<SpaceArchitectedByRelationship>
    {
        public SpaceArchitectedByRelationship()
        {
            Name = "architectedBy";
        }

        public SpaceArchitectedByRelationship(Space source, Agent target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SpaceArchitectedByRelationship);
        }

        public bool Equals(SpaceArchitectedByRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SpaceArchitectedByRelationship? left, SpaceArchitectedByRelationship? right)
        {
            return EqualityComparer<SpaceArchitectedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpaceArchitectedByRelationship? left, SpaceArchitectedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SpaceArchitectedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}