using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.sensor
{

    public class SensorObservesRelationship : Relationship<BasicDigitalTwin>, IEquatable<SensorObservesRelationship>
    {
        public SensorObservesRelationship()
        {
            Name = "observes";
        }

        public SensorObservesRelationship(Sensor source, BasicDigitalTwin target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SensorObservesRelationship);
        }

        public bool Equals(SensorObservesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SensorObservesRelationship? left, SensorObservesRelationship? right)
        {
            return EqualityComparer<SensorObservesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SensorObservesRelationship? left, SensorObservesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SensorObservesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}