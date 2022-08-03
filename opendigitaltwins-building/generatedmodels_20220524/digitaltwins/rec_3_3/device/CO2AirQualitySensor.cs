using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class CO2AirQualitySensor : AirQualitySensor, IEquatable<CO2AirQualitySensor>
    {
        public CO2AirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:CO2AirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CO2AirQualitySensor);
        }

        public bool Equals(CO2AirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CO2AirQualitySensor? left, CO2AirQualitySensor? right)
        {
            return EqualityComparer<CO2AirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(CO2AirQualitySensor? left, CO2AirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}