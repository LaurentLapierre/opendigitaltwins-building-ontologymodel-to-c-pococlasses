using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.thermalmeter
{

    public class ThermalMeterSubMeterOfRelationship : Relationship<ThermalMeter>, IEquatable<ThermalMeterSubMeterOfRelationship>
    {
        public ThermalMeterSubMeterOfRelationship()
        {
            Name = "subMeterOf";
        }

        public ThermalMeterSubMeterOfRelationship(ThermalMeter source, ThermalMeter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ThermalMeterSubMeterOfRelationship);
        }

        public bool Equals(ThermalMeterSubMeterOfRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ThermalMeterSubMeterOfRelationship? left, ThermalMeterSubMeterOfRelationship? right)
        {
            return EqualityComparer<ThermalMeterSubMeterOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ThermalMeterSubMeterOfRelationship? left, ThermalMeterSubMeterOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ThermalMeterSubMeterOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}