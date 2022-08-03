using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3
{

    public class SpaceCO2 : BasicDigitalTwin, IEquatable<SpaceCO2>, IEquatable<BasicDigitalTwin>
    {
        public SpaceCO2()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:SpaceCO2;1";
        [JsonPropertyName("CO2Sensor")]
        public double? CO2Sensor { get; set; }
        [JsonPropertyName("CO2Setpoint")]
        public double? CO2Setpoint { get; set; }
        [JsonPropertyName("CO2Delta")]
        public double? CO2Delta { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as SpaceCO2);
        }

        public bool Equals(SpaceCO2? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && CO2Sensor == other.CO2Sensor && CO2Setpoint == other.CO2Setpoint && CO2Delta == other.CO2Delta;
        }

        public static bool operator ==(SpaceCO2? left, SpaceCO2? right)
        {
            return EqualityComparer<SpaceCO2?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpaceCO2? left, SpaceCO2? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), CO2Sensor?.GetHashCode(), CO2Setpoint?.GetHashCode(), CO2Delta?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as SpaceCO2) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}