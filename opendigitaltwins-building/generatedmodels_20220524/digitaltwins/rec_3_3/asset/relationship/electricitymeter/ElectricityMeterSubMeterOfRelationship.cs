using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.electricitymeter
{

    public class ElectricityMeterSubMeterOfRelationship : Relationship<ElectricityMeter>, IEquatable<ElectricityMeterSubMeterOfRelationship>
    {
        public ElectricityMeterSubMeterOfRelationship()
        {
            Name = "subMeterOf";
        }

        public ElectricityMeterSubMeterOfRelationship(ElectricityMeter source, ElectricityMeter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricityMeterSubMeterOfRelationship);
        }

        public bool Equals(ElectricityMeterSubMeterOfRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ElectricityMeterSubMeterOfRelationship? left, ElectricityMeterSubMeterOfRelationship? right)
        {
            return EqualityComparer<ElectricityMeterSubMeterOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricityMeterSubMeterOfRelationship? left, ElectricityMeterSubMeterOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ElectricityMeterSubMeterOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}