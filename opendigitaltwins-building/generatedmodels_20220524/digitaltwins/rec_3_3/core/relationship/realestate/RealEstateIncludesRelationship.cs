using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.realestate
{

    public class RealEstateIncludesRelationship : Relationship<Space>, IEquatable<RealEstateIncludesRelationship>
    {
        public RealEstateIncludesRelationship()
        {
            Name = "includes";
        }

        public RealEstateIncludesRelationship(RealEstate source, Space target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as RealEstateIncludesRelationship);
        }

        public bool Equals(RealEstateIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(RealEstateIncludesRelationship? left, RealEstateIncludesRelationship? right)
        {
            return EqualityComparer<RealEstateIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(RealEstateIncludesRelationship? left, RealEstateIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as RealEstateIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}