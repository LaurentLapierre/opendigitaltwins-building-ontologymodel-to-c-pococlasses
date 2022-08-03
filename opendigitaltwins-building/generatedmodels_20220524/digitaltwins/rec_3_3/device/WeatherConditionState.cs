using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class WeatherConditionState : ConditionState, IEquatable<WeatherConditionState>
    {
        public WeatherConditionState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:WeatherConditionState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as WeatherConditionState);
        }

        public bool Equals(WeatherConditionState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(WeatherConditionState? left, WeatherConditionState? right)
        {
            return EqualityComparer<WeatherConditionState?>.Default.Equals(left, right);
        }

        public static bool operator !=(WeatherConditionState? left, WeatherConditionState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}