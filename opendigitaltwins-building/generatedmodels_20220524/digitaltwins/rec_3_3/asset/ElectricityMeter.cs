using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.electricitymeter;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElectricityMeter : Meter, IEquatable<ElectricityMeter>
    {
        public ElectricityMeter()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElectricityMeter;1";
        [JsonPropertyName("type")]
        public ElectricityMeterType? Type { get; set; }
        [JsonPropertyName("minVoltageRating")]
        public double? MinVoltageRating { get; set; }
        [JsonPropertyName("minCurrentRating")]
        public double? MinCurrentRating { get; set; }
        [JsonPropertyName("maxVoltageRating")]
        public double? MaxVoltageRating { get; set; }
        [JsonPropertyName("maxCurrentRating")]
        public double? MaxCurrentRating { get; set; }
        [JsonIgnore]
        public ElectricityMeterSubMeterOfRelationshipCollection SubMeterOf { get; set; } = new ElectricityMeterSubMeterOfRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricityMeter);
        }

        public bool Equals(ElectricityMeter? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && MinVoltageRating == other.MinVoltageRating && MinCurrentRating == other.MinCurrentRating && MaxVoltageRating == other.MaxVoltageRating && MaxCurrentRating == other.MaxCurrentRating;
        }

        public static bool operator ==(ElectricityMeter? left, ElectricityMeter? right)
        {
            return EqualityComparer<ElectricityMeter?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricityMeter? left, ElectricityMeter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), MinVoltageRating?.GetHashCode(), MinCurrentRating?.GetHashCode(), MaxVoltageRating?.GetHashCode(), MaxCurrentRating?.GetHashCode());
        }
    }
}