using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class CoolingTower : HVACEquipment, IEquatable<CoolingTower>
    {
        public CoolingTower()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:CoolingTower;1";
        [JsonPropertyName("nominalCoolingCapacity")]
        public double? NominalCoolingCapacity { get; set; }
        [JsonPropertyName("flowCapacity")]
        public double? FlowCapacity { get; set; }
        [JsonPropertyName("fan")]
        public Fan? Fan { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as CoolingTower);
        }

        public bool Equals(CoolingTower? other)
        {
            return other is not null && base.Equals(other) && NominalCoolingCapacity == other.NominalCoolingCapacity && FlowCapacity == other.FlowCapacity && Fan == other.Fan;
        }

        public static bool operator ==(CoolingTower? left, CoolingTower? right)
        {
            return EqualityComparer<CoolingTower?>.Default.Equals(left, right);
        }

        public static bool operator !=(CoolingTower? left, CoolingTower? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), NominalCoolingCapacity?.GetHashCode(), FlowCapacity?.GetHashCode(), Fan?.GetHashCode());
        }
    }
}