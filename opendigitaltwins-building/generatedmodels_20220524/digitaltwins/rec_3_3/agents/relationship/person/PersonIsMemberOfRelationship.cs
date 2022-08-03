using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.agents;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.agents.relationship.person
{

    public class PersonIsMemberOfRelationship : Relationship<Organization>, IEquatable<PersonIsMemberOfRelationship>
    {
        public PersonIsMemberOfRelationship()
        {
            Name = "isMemberOf";
        }

        public PersonIsMemberOfRelationship(Person source, Organization target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonIsMemberOfRelationship);
        }

        public bool Equals(PersonIsMemberOfRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PersonIsMemberOfRelationship? left, PersonIsMemberOfRelationship? right)
        {
            return EqualityComparer<PersonIsMemberOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonIsMemberOfRelationship? left, PersonIsMemberOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PersonIsMemberOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}