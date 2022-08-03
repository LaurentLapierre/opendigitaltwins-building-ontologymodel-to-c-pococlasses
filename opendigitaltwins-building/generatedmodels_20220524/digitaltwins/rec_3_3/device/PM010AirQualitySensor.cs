using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PM010AirQualitySensor : AirQualitySensor, IEquatable<PM010AirQualitySensor>
    {
        public PM010AirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PM010AirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PM010AirQualitySensor);
        }

        public bool Equals(PM010AirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PM010AirQualitySensor? left, PM010AirQualitySensor? right)
        {
            return EqualityComparer<PM010AirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(PM010AirQualitySensor? left, PM010AirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}