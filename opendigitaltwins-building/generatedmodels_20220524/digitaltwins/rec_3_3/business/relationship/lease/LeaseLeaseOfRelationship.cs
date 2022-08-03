using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.business;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.business.relationship.lease
{

    public class LeaseLeaseOfRelationship : Relationship<BasicDigitalTwin>, IEquatable<LeaseLeaseOfRelationship>
    {
        public LeaseLeaseOfRelationship()
        {
            Name = "leaseOf";
        }

        public LeaseLeaseOfRelationship(Lease source, BasicDigitalTwin target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as LeaseLeaseOfRelationship);
        }

        public bool Equals(LeaseLeaseOfRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(LeaseLeaseOfRelationship? left, LeaseLeaseOfRelationship? right)
        {
            return EqualityComparer<LeaseLeaseOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(LeaseLeaseOfRelationship? left, LeaseLeaseOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as LeaseLeaseOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}