using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using opendigitaltwins.building.digitaltwins.rec_3_3.business;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.agent
{

    public class AgentHasRoleRelationship : Relationship<Role>, IEquatable<AgentHasRoleRelationship>
    {
        public AgentHasRoleRelationship()
        {
            Name = "hasRole";
        }

        public AgentHasRoleRelationship(Agent source, Role target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as AgentHasRoleRelationship);
        }

        public bool Equals(AgentHasRoleRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(AgentHasRoleRelationship? left, AgentHasRoleRelationship? right)
        {
            return EqualityComparer<AgentHasRoleRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(AgentHasRoleRelationship? left, AgentHasRoleRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as AgentHasRoleRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}