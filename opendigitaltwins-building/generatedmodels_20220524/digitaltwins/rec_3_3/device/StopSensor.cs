using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class StopSensor : StartStopSensor, IEquatable<StopSensor>
    {
        public StopSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:StopSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StopSensor);
        }

        public bool Equals(StopSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StopSensor? left, StopSensor? right)
        {
            return EqualityComparer<StopSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(StopSensor? left, StopSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}