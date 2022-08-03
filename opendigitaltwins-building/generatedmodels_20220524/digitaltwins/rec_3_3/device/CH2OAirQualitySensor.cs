using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class CH2OAirQualitySensor : AirQualitySensor, IEquatable<CH2OAirQualitySensor>
    {
        public CH2OAirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:CH2OAirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CH2OAirQualitySensor);
        }

        public bool Equals(CH2OAirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CH2OAirQualitySensor? left, CH2OAirQualitySensor? right)
        {
            return EqualityComparer<CH2OAirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(CH2OAirQualitySensor? left, CH2OAirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}