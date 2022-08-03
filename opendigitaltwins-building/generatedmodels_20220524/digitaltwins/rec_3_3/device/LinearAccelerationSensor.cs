using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class LinearAccelerationSensor : AccelerationSensor, IEquatable<LinearAccelerationSensor>
    {
        public LinearAccelerationSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:LinearAccelerationSensor;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as LinearAccelerationSensor);
        }

        public bool Equals(LinearAccelerationSensor? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(LinearAccelerationSensor? left, LinearAccelerationSensor? right)
        {
            return EqualityComparer<LinearAccelerationSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(LinearAccelerationSensor? left, LinearAccelerationSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}