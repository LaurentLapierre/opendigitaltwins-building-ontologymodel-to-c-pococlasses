using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.agents;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.agents.relationship.organization
{

    public class OrganizationHasMemberRelationship : Relationship<Person>, IEquatable<OrganizationHasMemberRelationship>
    {
        public OrganizationHasMemberRelationship()
        {
            Name = "hasMember";
        }

        public OrganizationHasMemberRelationship(Organization source, Person target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as OrganizationHasMemberRelationship);
        }

        public bool Equals(OrganizationHasMemberRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(OrganizationHasMemberRelationship? left, OrganizationHasMemberRelationship? right)
        {
            return EqualityComparer<OrganizationHasMemberRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(OrganizationHasMemberRelationship? left, OrganizationHasMemberRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as OrganizationHasMemberRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}