using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.watermeter
{

    public class WaterMeterMeasuresRelationship : Relationship<BasicDigitalTwin>, IEquatable<WaterMeterMeasuresRelationship>
    {
        public WaterMeterMeasuresRelationship()
        {
            Name = "measures";
        }

        public WaterMeterMeasuresRelationship(WaterMeter source, BasicDigitalTwin target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as WaterMeterMeasuresRelationship);
        }

        public bool Equals(WaterMeterMeasuresRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(WaterMeterMeasuresRelationship? left, WaterMeterMeasuresRelationship? right)
        {
            return EqualityComparer<WaterMeterMeasuresRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(WaterMeterMeasuresRelationship? left, WaterMeterMeasuresRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as WaterMeterMeasuresRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}