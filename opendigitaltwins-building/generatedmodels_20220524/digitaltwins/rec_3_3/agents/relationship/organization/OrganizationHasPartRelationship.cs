using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.agents;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.agents.relationship.organization
{

    public class OrganizationHasPartRelationship : Relationship<Organization>, IEquatable<OrganizationHasPartRelationship>
    {
        public OrganizationHasPartRelationship()
        {
            Name = "hasPart";
        }

        public OrganizationHasPartRelationship(Organization source, Organization target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OrganizationHasPartRelationship);
        }

        public bool Equals(OrganizationHasPartRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OrganizationHasPartRelationship? left, OrganizationHasPartRelationship? right)
        {
            return EqualityComparer<OrganizationHasPartRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OrganizationHasPartRelationship? left, OrganizationHasPartRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OrganizationHasPartRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}