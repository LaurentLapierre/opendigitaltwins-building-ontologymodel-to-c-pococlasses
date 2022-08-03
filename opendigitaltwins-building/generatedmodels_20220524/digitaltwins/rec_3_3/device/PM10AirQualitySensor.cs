using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PM10AirQualitySensor : AirQualitySensor, IEquatable<PM10AirQualitySensor>
    {
        public PM10AirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PM10AirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PM10AirQualitySensor);
        }

        public bool Equals(PM10AirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PM10AirQualitySensor? left, PM10AirQualitySensor? right)
        {
            return EqualityComparer<PM10AirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(PM10AirQualitySensor? left, PM10AirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}