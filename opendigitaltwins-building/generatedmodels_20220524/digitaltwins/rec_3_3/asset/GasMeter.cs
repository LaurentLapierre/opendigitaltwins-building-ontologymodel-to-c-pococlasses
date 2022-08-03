using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.gasmeter;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class GasMeter : Meter, IEquatable<GasMeter>
    {
        public GasMeter()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:GasMeter;1";
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("minTemperatureRating")]
        public double? MinTemperatureRating { get; set; }
        [JsonPropertyName("minMassFlowRating")]
        public double? MinMassFlowRating { get; set; }
        [JsonPropertyName("maxTemperatureRating")]
        public double? MaxTemperatureRating { get; set; }
        [JsonPropertyName("maxPressureRating")]
        public double? MaxPressureRating { get; set; }
        [JsonPropertyName("maxMassFlowRating")]
        public double? MaxMassFlowRating { get; set; }
        [JsonIgnore]
        public GasMeterSubMeterOfRelationshipCollection SubMeterOf { get; set; } = new GasMeterSubMeterOfRelationshipCollection();
        [JsonIgnore]
        public GasMeterMeasuresRelationshipCollection Measures { get; set; } = new GasMeterMeasuresRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as GasMeter);
        }

        public bool Equals(GasMeter? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && MinTemperatureRating == other.MinTemperatureRating && MinMassFlowRating == other.MinMassFlowRating && MaxTemperatureRating == other.MaxTemperatureRating && MaxPressureRating == other.MaxPressureRating && MaxMassFlowRating == other.MaxMassFlowRating;
        }

        public static bool operator ==(GasMeter? left, GasMeter? right)
        {
            return EqualityComparer<GasMeter?>.Default.Equals(left, right);
        }

        public static bool operator !=(GasMeter? left, GasMeter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), MinTemperatureRating?.GetHashCode(), MinMassFlowRating?.GetHashCode(), MaxTemperatureRating?.GetHashCode(), MaxPressureRating?.GetHashCode(), MaxMassFlowRating?.GetHashCode());
        }
    }
}