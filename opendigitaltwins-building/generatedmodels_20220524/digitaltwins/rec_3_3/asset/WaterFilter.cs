using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class WaterFilter : HVACWaterTreatment, IEquatable<WaterFilter>
    {
        public WaterFilter()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:WaterFilter;1";
        [JsonPropertyName("workingPressure")]
        public double? WorkingPressure { get; set; }
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("tankCapacity")]
        public double? TankCapacity { get; set; }
        [JsonPropertyName("flowCapacity")]
        public double? FlowCapacity { get; set; }
        [JsonPropertyName("filtrationRating")]
        public int? FiltrationRating { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as WaterFilter);
        }

        public bool Equals(WaterFilter? other)
        {
            return other is not null && base.Equals(other) && WorkingPressure == other.WorkingPressure && Type == other.Type && TankCapacity == other.TankCapacity && FlowCapacity == other.FlowCapacity && FiltrationRating == other.FiltrationRating;
        }

        public static bool operator ==(WaterFilter? left, WaterFilter? right)
        {
            return EqualityComparer<WaterFilter?>.Default.Equals(left, right);
        }

        public static bool operator !=(WaterFilter? left, WaterFilter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), WorkingPressure?.GetHashCode(), Type?.GetHashCode(), TankCapacity?.GetHashCode(), FlowCapacity?.GetHashCode(), FiltrationRating?.GetHashCode());
        }
    }
}