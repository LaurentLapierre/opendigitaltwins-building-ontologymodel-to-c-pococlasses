using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.sensor;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Sensor : Capability, IEquatable<Sensor>
    {
        public Sensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Sensor;1";
        [JsonIgnore]
        public SensorObservesRelationshipCollection Observes { get; set; } = new SensorObservesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as Sensor);
        }

        public bool Equals(Sensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Sensor? left, Sensor? right)
        {
            return EqualityComparer<Sensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(Sensor? left, Sensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}