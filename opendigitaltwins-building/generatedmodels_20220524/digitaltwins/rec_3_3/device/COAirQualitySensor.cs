using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class COAirQualitySensor : AirQualitySensor, IEquatable<COAirQualitySensor>
    {
        public COAirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:COAirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as COAirQualitySensor);
        }

        public bool Equals(COAirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(COAirQualitySensor? left, COAirQualitySensor? right)
        {
            return EqualityComparer<COAirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(COAirQualitySensor? left, COAirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}