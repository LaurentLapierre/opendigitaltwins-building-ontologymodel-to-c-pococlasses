using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.actuator;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Actuator : Capability, IEquatable<Actuator>
    {
        public Actuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Actuator;1";
        [JsonIgnore]
        public ActuatorObservedByRelationshipCollection ObservedBy { get; set; } = new ActuatorObservedByRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as Actuator);
        }

        public bool Equals(Actuator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Actuator? left, Actuator? right)
        {
            return EqualityComparer<Actuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(Actuator? left, Actuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}