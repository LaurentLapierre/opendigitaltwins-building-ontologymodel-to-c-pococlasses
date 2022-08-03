using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class O2AirQualitySensor : AirQualitySensor, IEquatable<O2AirQualitySensor>
    {
        public O2AirQualitySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:O2AirQualitySensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as O2AirQualitySensor);
        }

        public bool Equals(O2AirQualitySensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(O2AirQualitySensor? left, O2AirQualitySensor? right)
        {
            return EqualityComparer<O2AirQualitySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(O2AirQualitySensor? left, O2AirQualitySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}