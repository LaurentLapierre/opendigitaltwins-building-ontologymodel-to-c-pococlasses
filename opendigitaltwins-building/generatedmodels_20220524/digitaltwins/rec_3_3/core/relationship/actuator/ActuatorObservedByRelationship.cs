using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.actuator
{

    public class ActuatorObservedByRelationship : Relationship<Sensor>, IEquatable<ActuatorObservedByRelationship>
    {
        public ActuatorObservedByRelationship()
        {
            Name = "observedBy";
        }

        public ActuatorObservedByRelationship(Actuator source, Sensor target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ActuatorObservedByRelationship);
        }

        public bool Equals(ActuatorObservedByRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ActuatorObservedByRelationship? left, ActuatorObservedByRelationship? right)
        {
            return EqualityComparer<ActuatorObservedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ActuatorObservedByRelationship? left, ActuatorObservedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ActuatorObservedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}