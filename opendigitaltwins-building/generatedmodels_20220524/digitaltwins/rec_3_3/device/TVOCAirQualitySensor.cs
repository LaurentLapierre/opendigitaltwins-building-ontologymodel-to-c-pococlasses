using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class TVOCAirQualitySensor : AirQualitySensor, IEquatable<TVOCAirQualitySensor>
    {
        public TVOCAirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:TVOCAirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as TVOCAirQualitySensor);
        }

        public bool Equals(TVOCAirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(TVOCAirQualitySensor? left, TVOCAirQualitySensor? right)
        {
            return EqualityComparer<TVOCAirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(TVOCAirQualitySensor? left, TVOCAirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}