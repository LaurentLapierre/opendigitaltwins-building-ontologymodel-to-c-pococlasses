using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.business;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.business.relationship.tenantunit
{

    public class TenantUnitIncludesRelationship : Relationship<Space>, IEquatable<TenantUnitIncludesRelationship>
    {
        public TenantUnitIncludesRelationship()
        {
            Name = "includes";
        }

        public TenantUnitIncludesRelationship(TenantUnit source, Space target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TenantUnitIncludesRelationship);
        }

        public bool Equals(TenantUnitIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(TenantUnitIncludesRelationship? left, TenantUnitIncludesRelationship? right)
        {
            return EqualityComparer<TenantUnitIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(TenantUnitIncludesRelationship? left, TenantUnitIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as TenantUnitIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}