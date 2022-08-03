using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class SpeedSensor : QuantitySensor, IEquatable<SpeedSensor>
    {
        public SpeedSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:SpeedSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SpeedSensor);
        }

        public bool Equals(SpeedSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SpeedSensor? left, SpeedSensor? right)
        {
            return EqualityComparer<SpeedSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpeedSensor? left, SpeedSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}