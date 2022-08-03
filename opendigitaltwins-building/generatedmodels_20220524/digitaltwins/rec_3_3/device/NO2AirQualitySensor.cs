using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NO2AirQualitySensor : AirQualitySensor, IEquatable<NO2AirQualitySensor>
    {
        public NO2AirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NO2AirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NO2AirQualitySensor);
        }

        public bool Equals(NO2AirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NO2AirQualitySensor? left, NO2AirQualitySensor? right)
        {
            return EqualityComparer<NO2AirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(NO2AirQualitySensor? left, NO2AirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}