using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.business;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.business.relationship.lease
{

    public class LeaseRegulatedByRelationship : Relationship<LeaseContract>, IEquatable<LeaseRegulatedByRelationship>
    {
        public LeaseRegulatedByRelationship()
        {
            Name = "regulatedBy";
        }

        public LeaseRegulatedByRelationship(Lease source, LeaseContract target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as LeaseRegulatedByRelationship);
        }

        public bool Equals(LeaseRegulatedByRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(LeaseRegulatedByRelationship? left, LeaseRegulatedByRelationship? right)
        {
            return EqualityComparer<LeaseRegulatedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(LeaseRegulatedByRelationship? left, LeaseRegulatedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as LeaseRegulatedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}