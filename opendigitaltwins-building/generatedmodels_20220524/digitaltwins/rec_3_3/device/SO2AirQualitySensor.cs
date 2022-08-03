using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class SO2AirQualitySensor : AirQualitySensor, IEquatable<SO2AirQualitySensor>
    {
        public SO2AirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:SO2AirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SO2AirQualitySensor);
        }

        public bool Equals(SO2AirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SO2AirQualitySensor? left, SO2AirQualitySensor? right)
        {
            return EqualityComparer<SO2AirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(SO2AirQualitySensor? left, SO2AirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}