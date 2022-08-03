using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class NOxAirQualitySensor : AirQualitySensor, IEquatable<NOxAirQualitySensor>
    {
        public NOxAirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:NOxAirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as NOxAirQualitySensor);
        }

        public bool Equals(NOxAirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(NOxAirQualitySensor? left, NOxAirQualitySensor? right)
        {
            return EqualityComparer<NOxAirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(NOxAirQualitySensor? left, NOxAirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}