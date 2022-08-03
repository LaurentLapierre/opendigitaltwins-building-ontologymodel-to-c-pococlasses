using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3
{

    public class SpaceTemperature : BasicDigitalTwin, IEquatable<SpaceTemperature>, IEquatable<BasicDigitalTwin>
    {
        public SpaceTemperature()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:SpaceTemperature;1";
        [JsonPropertyName("temperatureSensor")]
        public double? TemperatureSensor { get; set; }
        [JsonPropertyName("temperatureSetpoint")]
        public double? TemperatureSetpoint { get; set; }
        [JsonPropertyName("temperatureDelta")]
        public double? TemperatureDelta { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as SpaceTemperature);
        }

        public bool Equals(SpaceTemperature? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && TemperatureSensor == other.TemperatureSensor && TemperatureSetpoint == other.TemperatureSetpoint && TemperatureDelta == other.TemperatureDelta;
        }

        public static bool operator ==(SpaceTemperature? left, SpaceTemperature? right)
        {
            return EqualityComparer<SpaceTemperature?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpaceTemperature? left, SpaceTemperature? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), TemperatureSensor?.GetHashCode(), TemperatureSetpoint?.GetHashCode(), TemperatureDelta?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as SpaceTemperature) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}