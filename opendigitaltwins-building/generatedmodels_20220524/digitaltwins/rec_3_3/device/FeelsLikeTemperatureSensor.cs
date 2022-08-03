using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FeelsLikeTemperatureSensor : TemperatureSensor, IEquatable<FeelsLikeTemperatureSensor>
    {
        public FeelsLikeTemperatureSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FeelsLikeTemperatureSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FeelsLikeTemperatureSensor);
        }

        public bool Equals(FeelsLikeTemperatureSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FeelsLikeTemperatureSensor? left, FeelsLikeTemperatureSensor? right)
        {
            return EqualityComparer<FeelsLikeTemperatureSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(FeelsLikeTemperatureSensor? left, FeelsLikeTemperatureSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}