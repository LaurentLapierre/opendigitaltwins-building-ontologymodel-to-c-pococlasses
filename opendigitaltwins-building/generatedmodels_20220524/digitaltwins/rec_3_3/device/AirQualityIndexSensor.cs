using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class AirQualityIndexSensor : AirQualitySensor, IEquatable<AirQualityIndexSensor>
    {
        public AirQualityIndexSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:AirQualityIndexSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AirQualityIndexSensor);
        }

        public bool Equals(AirQualityIndexSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AirQualityIndexSensor? left, AirQualityIndexSensor? right)
        {
            return EqualityComparer<AirQualityIndexSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(AirQualityIndexSensor? left, AirQualityIndexSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}