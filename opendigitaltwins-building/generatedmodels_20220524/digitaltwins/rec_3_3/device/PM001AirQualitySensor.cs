using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PM001AirQualitySensor : AirQualitySensor, IEquatable<PM001AirQualitySensor>
    {
        public PM001AirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PM001AirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PM001AirQualitySensor);
        }

        public bool Equals(PM001AirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PM001AirQualitySensor? left, PM001AirQualitySensor? right)
        {
            return EqualityComparer<PM001AirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(PM001AirQualitySensor? left, PM001AirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}