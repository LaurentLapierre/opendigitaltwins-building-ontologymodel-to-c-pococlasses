using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PbAirQualitySensor : AirQualitySensor, IEquatable<PbAirQualitySensor>
    {
        public PbAirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PbAirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PbAirQualitySensor);
        }

        public bool Equals(PbAirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PbAirQualitySensor? left, PbAirQualitySensor? right)
        {
            return EqualityComparer<PbAirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(PbAirQualitySensor? left, PbAirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}