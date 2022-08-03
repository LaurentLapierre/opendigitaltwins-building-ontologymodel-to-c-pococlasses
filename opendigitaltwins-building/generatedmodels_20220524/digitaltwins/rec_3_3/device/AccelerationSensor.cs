using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class AccelerationSensor : QuantitySensor, IEquatable<AccelerationSensor>
    {
        public AccelerationSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:AccelerationSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AccelerationSensor);
        }

        public bool Equals(AccelerationSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AccelerationSensor? left, AccelerationSensor? right)
        {
            return EqualityComparer<AccelerationSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(AccelerationSensor? left, AccelerationSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}