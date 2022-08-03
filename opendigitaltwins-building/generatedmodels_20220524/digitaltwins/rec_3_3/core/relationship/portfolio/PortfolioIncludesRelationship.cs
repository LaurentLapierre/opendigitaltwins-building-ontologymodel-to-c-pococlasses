using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.portfolio
{

    public class PortfolioIncludesRelationship : Relationship<BasicDigitalTwin>, IEquatable<PortfolioIncludesRelationship>
    {
        public PortfolioIncludesRelationship()
        {
            Name = "includes";
        }

        public PortfolioIncludesRelationship(Portfolio source, BasicDigitalTwin target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PortfolioIncludesRelationship);
        }

        public bool Equals(PortfolioIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PortfolioIncludesRelationship? left, PortfolioIncludesRelationship? right)
        {
            return EqualityComparer<PortfolioIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PortfolioIncludesRelationship? left, PortfolioIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PortfolioIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}