using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class FeelsLikeTemperatureSetpoint : TemperatureSetpoint, IEquatable<FeelsLikeTemperatureSetpoint>
    {
        public FeelsLikeTemperatureSetpoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:FeelsLikeTemperatureSetpoint;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as FeelsLikeTemperatureSetpoint);
        }

        public bool Equals(FeelsLikeTemperatureSetpoint? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FeelsLikeTemperatureSetpoint? left, FeelsLikeTemperatureSetpoint? right)
        {
            return EqualityComparer<FeelsLikeTemperatureSetpoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(FeelsLikeTemperatureSetpoint? left, FeelsLikeTemperatureSetpoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}