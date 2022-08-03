using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PM025AirQualitySensor : AirQualitySensor, IEquatable<PM025AirQualitySensor>
    {
        public PM025AirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PM025AirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PM025AirQualitySensor);
        }

        public bool Equals(PM025AirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PM025AirQualitySensor? left, PM025AirQualitySensor? right)
        {
            return EqualityComparer<PM025AirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(PM025AirQualitySensor? left, PM025AirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}