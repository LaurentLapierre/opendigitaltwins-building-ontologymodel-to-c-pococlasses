using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.thermalmeter
{

    public class ThermalMeterMeasuresRelationship : Relationship<BasicDigitalTwin>, IEquatable<ThermalMeterMeasuresRelationship>
    {
        public ThermalMeterMeasuresRelationship()
        {
            Name = "measures";
        }

        public ThermalMeterMeasuresRelationship(ThermalMeter source, BasicDigitalTwin target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ThermalMeterMeasuresRelationship);
        }

        public bool Equals(ThermalMeterMeasuresRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ThermalMeterMeasuresRelationship? left, ThermalMeterMeasuresRelationship? right)
        {
            return EqualityComparer<ThermalMeterMeasuresRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ThermalMeterMeasuresRelationship? left, ThermalMeterMeasuresRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ThermalMeterMeasuresRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}