using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HeatExchanger : HVACEquipment, IEquatable<HeatExchanger>
    {
        public HeatExchanger()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HeatExchanger;1";
        [JsonPropertyName("secondaryMaxTemperature")]
        public double? SecondaryMaxTemperature { get; set; }
        [JsonPropertyName("secondaryMaxPressure")]
        public double? SecondaryMaxPressure { get; set; }
        [JsonPropertyName("secondaryFlowCapacity")]
        public double? SecondaryFlowCapacity { get; set; }
        [JsonPropertyName("primaryMaxTemperature")]
        public double? PrimaryMaxTemperature { get; set; }
        [JsonPropertyName("primaryMaxPressure")]
        public double? PrimaryMaxPressure { get; set; }
        [JsonPropertyName("primaryFlowCapacity")]
        public double? PrimaryFlowCapacity { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as HeatExchanger);
        }

        public bool Equals(HeatExchanger? other)
        {
            return other is not null && base.Equals(other) && SecondaryMaxTemperature == other.SecondaryMaxTemperature && SecondaryMaxPressure == other.SecondaryMaxPressure && SecondaryFlowCapacity == other.SecondaryFlowCapacity && PrimaryMaxTemperature == other.PrimaryMaxTemperature && PrimaryMaxPressure == other.PrimaryMaxPressure && PrimaryFlowCapacity == other.PrimaryFlowCapacity;
        }

        public static bool operator ==(HeatExchanger? left, HeatExchanger? right)
        {
            return EqualityComparer<HeatExchanger?>.Default.Equals(left, right);
        }

        public static bool operator !=(HeatExchanger? left, HeatExchanger? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), SecondaryMaxTemperature?.GetHashCode(), SecondaryMaxPressure?.GetHashCode(), SecondaryFlowCapacity?.GetHashCode(), PrimaryMaxTemperature?.GetHashCode(), PrimaryMaxPressure?.GetHashCode(), PrimaryFlowCapacity?.GetHashCode());
        }
    }
}