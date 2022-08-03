using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FanCoilUnit : TerminalUnit, IEquatable<FanCoilUnit>
    {
        public FanCoilUnit()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FanCoilUnit;1";
        [JsonPropertyName("type")]
        public FanCoilUnitType? Type { get; set; }
        [JsonPropertyName("refrigerantType")]
        public string? RefrigerantType { get; set; }
        [JsonPropertyName("nominalCoolingCapacity")]
        public double? NominalCoolingCapacity { get; set; }
        [JsonPropertyName("netSensibleCoolingCapacity")]
        public double? NetSensibleCoolingCapacity { get; set; }
        [JsonPropertyName("mounting")]
        public FanCoilUnitMounting? Mounting { get; set; }
        [JsonPropertyName("filterType")]
        public string? FilterType { get; set; }
        [JsonPropertyName("secondaryCoolingMethod")]
        public HVACCoolingMethod? SecondaryCoolingMethod { get; set; }
        [JsonPropertyName("primaryCoolingMethod")]
        public HVACCoolingMethod? PrimaryCoolingMethod { get; set; }
        [JsonPropertyName("fan")]
        public Fan? Fan { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as FanCoilUnit);
        }

        public bool Equals(FanCoilUnit? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && RefrigerantType == other.RefrigerantType && NominalCoolingCapacity == other.NominalCoolingCapacity && NetSensibleCoolingCapacity == other.NetSensibleCoolingCapacity && Mounting == other.Mounting && FilterType == other.FilterType && SecondaryCoolingMethod == other.SecondaryCoolingMethod && PrimaryCoolingMethod == other.PrimaryCoolingMethod && Fan == other.Fan;
        }

        public static bool operator ==(FanCoilUnit? left, FanCoilUnit? right)
        {
            return EqualityComparer<FanCoilUnit?>.Default.Equals(left, right);
        }

        public static bool operator !=(FanCoilUnit? left, FanCoilUnit? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), RefrigerantType?.GetHashCode(), NominalCoolingCapacity?.GetHashCode(), NetSensibleCoolingCapacity?.GetHashCode(), Mounting?.GetHashCode(), FilterType?.GetHashCode(), SecondaryCoolingMethod?.GetHashCode(), PrimaryCoolingMethod?.GetHashCode(), Fan?.GetHashCode());
        }
    }
}