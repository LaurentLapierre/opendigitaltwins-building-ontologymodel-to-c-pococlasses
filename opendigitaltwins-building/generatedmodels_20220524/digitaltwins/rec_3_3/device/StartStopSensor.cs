using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StartStopSensor : BinarySensor, IEquatable<StartStopSensor>
    {
        public StartStopSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StartStopSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StartStopSensor);
        }

        public bool Equals(StartStopSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StartStopSensor? left, StartStopSensor? right)
        {
            return EqualityComparer<StartStopSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(StartStopSensor? left, StartStopSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}