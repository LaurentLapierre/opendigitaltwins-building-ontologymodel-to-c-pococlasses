using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HotWaterUnitHeater : UnitHeater, IEquatable<HotWaterUnitHeater>
    {
        public HotWaterUnitHeater()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HotWaterUnitHeater;1";
        [JsonPropertyName("flowCapacity")]
        public double? FlowCapacity { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as HotWaterUnitHeater);
        }

        public bool Equals(HotWaterUnitHeater? other)
        {
            return other is not null && base.Equals(other) && FlowCapacity == other.FlowCapacity;
        }

        public static bool operator ==(HotWaterUnitHeater? left, HotWaterUnitHeater? right)
        {
            return EqualityComparer<HotWaterUnitHeater?>.Default.Equals(left, right);
        }

        public static bool operator !=(HotWaterUnitHeater? left, HotWaterUnitHeater? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), FlowCapacity?.GetHashCode());
        }
    }
}