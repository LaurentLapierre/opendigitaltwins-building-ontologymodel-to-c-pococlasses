using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.business;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.business.relationship.lease
{

    public class LeaseLeaseeRelationship : Relationship<Agent>, IEquatable<LeaseLeaseeRelationship>
    {
        public LeaseLeaseeRelationship()
        {
            Name = "leasee";
        }

        public LeaseLeaseeRelationship(Lease source, Agent target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as LeaseLeaseeRelationship);
        }

        public bool Equals(LeaseLeaseeRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(LeaseLeaseeRelationship? left, LeaseLeaseeRelationship? right)
        {
            return EqualityComparer<LeaseLeaseeRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(LeaseLeaseeRelationship? left, LeaseLeaseeRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as LeaseLeaseeRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}