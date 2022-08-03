using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.agent
{

    public class AgentOwnsRelationship : Relationship<BasicDigitalTwin>, IEquatable<AgentOwnsRelationship>
    {
        public AgentOwnsRelationship()
        {
            Name = "owns";
        }

        public AgentOwnsRelationship(Agent source, BasicDigitalTwin target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as AgentOwnsRelationship);
        }

        public bool Equals(AgentOwnsRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(AgentOwnsRelationship? left, AgentOwnsRelationship? right)
        {
            return EqualityComparer<AgentOwnsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(AgentOwnsRelationship? left, AgentOwnsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as AgentOwnsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}