using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.thermalmeter;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ThermalMeter : Meter, IEquatable<ThermalMeter>
    {
        public ThermalMeter()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ThermalMeter;1";
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("minVolumeFlowRating")]
        public double? MinVolumeFlowRating { get; set; }
        [JsonPropertyName("minTemperatureRating")]
        public double? MinTemperatureRating { get; set; }
        [JsonPropertyName("maxVolumeFlowRating")]
        public double? MaxVolumeFlowRating { get; set; }
        [JsonPropertyName("maxTemperatureRating")]
        public double? MaxTemperatureRating { get; set; }
        [JsonPropertyName("maxPressureRating")]
        public double? MaxPressureRating { get; set; }
        [JsonIgnore]
        public ThermalMeterSubMeterOfRelationshipCollection SubMeterOf { get; set; } = new ThermalMeterSubMeterOfRelationshipCollection();
        [JsonIgnore]
        public ThermalMeterMeasuresRelationshipCollection Measures { get; set; } = new ThermalMeterMeasuresRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as ThermalMeter);
        }

        public bool Equals(ThermalMeter? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && MinVolumeFlowRating == other.MinVolumeFlowRating && MinTemperatureRating == other.MinTemperatureRating && MaxVolumeFlowRating == other.MaxVolumeFlowRating && MaxTemperatureRating == other.MaxTemperatureRating && MaxPressureRating == other.MaxPressureRating;
        }

        public static bool operator ==(ThermalMeter? left, ThermalMeter? right)
        {
            return EqualityComparer<ThermalMeter?>.Default.Equals(left, right);
        }

        public static bool operator !=(ThermalMeter? left, ThermalMeter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), MinVolumeFlowRating?.GetHashCode(), MinTemperatureRating?.GetHashCode(), MaxVolumeFlowRating?.GetHashCode(), MaxTemperatureRating?.GetHashCode(), MaxPressureRating?.GetHashCode());
        }
    }
}