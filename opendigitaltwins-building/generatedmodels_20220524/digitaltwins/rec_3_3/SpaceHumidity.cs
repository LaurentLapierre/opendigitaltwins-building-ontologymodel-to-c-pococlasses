using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3
{

    public class SpaceHumidity : BasicDigitalTwin, IEquatable<SpaceHumidity>, IEquatable<BasicDigitalTwin>
    {
        public SpaceHumidity()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:SpaceHumidity;1";
        [JsonPropertyName("humiditySensor")]
        public double? HumiditySensor { get; set; }
        [JsonPropertyName("humiditySetpoint")]
        public double? HumiditySetpoint { get; set; }
        [JsonPropertyName("humidityDelta")]
        public double? HumidityDelta { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as SpaceHumidity);
        }

        public bool Equals(SpaceHumidity? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && HumiditySensor == other.HumiditySensor && HumiditySetpoint == other.HumiditySetpoint && HumidityDelta == other.HumidityDelta;
        }

        public static bool operator ==(SpaceHumidity? left, SpaceHumidity? right)
        {
            return EqualityComparer<SpaceHumidity?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpaceHumidity? left, SpaceHumidity? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), HumiditySensor?.GetHashCode(), HumiditySetpoint?.GetHashCode(), HumidityDelta?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as SpaceHumidity) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}