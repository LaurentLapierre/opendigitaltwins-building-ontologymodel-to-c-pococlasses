using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StateSensor : Sensor, IEquatable<StateSensor>
    {
        public StateSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StateSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StateSensor);
        }

        public bool Equals(StateSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StateSensor? left, StateSensor? right)
        {
            return EqualityComparer<StateSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(StateSensor? left, StateSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}