using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class AirHandlingUnit : HVACEquipment, IEquatable<AirHandlingUnit>
    {
        public AirHandlingUnit()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:AirHandlingUnit;1";
        [JsonPropertyName("zoneDelivery")]
        public AirHandlingUnitZoneDelivery? ZoneDelivery { get; set; }
        [JsonPropertyName("ventilationStrategy")]
        public AirHandlingUnitVentilationStrategy? VentilationStrategy { get; set; }
        [JsonPropertyName("ventilationConfiguration")]
        public AirHandlingUnitVentilationConfiguration? VentilationConfiguration { get; set; }
        [JsonPropertyName("refrigerantType")]
        public string? RefrigerantType { get; set; }
        [JsonPropertyName("nominalHeatingCapacity")]
        public double? NominalHeatingCapacity { get; set; }
        [JsonPropertyName("nominalCoolingCapacity")]
        public double? NominalCoolingCapacity { get; set; }
        [JsonPropertyName("netSensibleCoolingCapacity")]
        public double? NetSensibleCoolingCapacity { get; set; }
        [JsonPropertyName("humidificationMethod")]
        public AirHandlingUnitHumidificationMethod? HumidificationMethod { get; set; }
        [JsonPropertyName("filterType")]
        public string? FilterType { get; set; }
        [JsonPropertyName("dischargeDuctworkConfiguration")]
        public AirHandlingUnitDischargeDuctworkConfiguration? DischargeDuctworkConfiguration { get; set; }
        [JsonPropertyName("dehumidificationMethod")]
        public AirHandlingUnitDehumidificationMethod? DehumidificationMethod { get; set; }
        [JsonPropertyName("airflowModulation")]
        public AirHandlingUnitAirflowModulation? AirflowModulation { get; set; }
        [JsonPropertyName("supplyFan")]
        public Fan? SupplyFan { get; set; }
        [JsonPropertyName("secondaryCoolingMethod")]
        public HVACCoolingMethod? SecondaryCoolingMethod { get; set; }
        [JsonPropertyName("returnFan")]
        public Fan? ReturnFan { get; set; }
        [JsonPropertyName("reHeatingMethod")]
        public HVACHeatingMethod? ReHeatingMethod { get; set; }
        [JsonPropertyName("primaryCoolingMethod")]
        public HVACCoolingMethod? PrimaryCoolingMethod { get; set; }
        [JsonPropertyName("preHeatingMethod")]
        public HVACHeatingMethod? PreHeatingMethod { get; set; }
        [JsonPropertyName("mixingBox")]
        public HVACMixingBox? MixingBox { get; set; }
        [JsonPropertyName("exhaustFan")]
        public Fan? ExhaustFan { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as AirHandlingUnit);
        }

        public bool Equals(AirHandlingUnit? other)
        {
            return other is not null && base.Equals(other) && ZoneDelivery == other.ZoneDelivery && VentilationStrategy == other.VentilationStrategy && VentilationConfiguration == other.VentilationConfiguration && RefrigerantType == other.RefrigerantType && NominalHeatingCapacity == other.NominalHeatingCapacity && NominalCoolingCapacity == other.NominalCoolingCapacity && NetSensibleCoolingCapacity == other.NetSensibleCoolingCapacity && HumidificationMethod == other.HumidificationMethod && FilterType == other.FilterType && DischargeDuctworkConfiguration == other.DischargeDuctworkConfiguration && DehumidificationMethod == other.DehumidificationMethod && AirflowModulation == other.AirflowModulation && SupplyFan == other.SupplyFan && SecondaryCoolingMethod == other.SecondaryCoolingMethod && ReturnFan == other.ReturnFan && ReHeatingMethod == other.ReHeatingMethod && PrimaryCoolingMethod == other.PrimaryCoolingMethod && PreHeatingMethod == other.PreHeatingMethod && MixingBox == other.MixingBox && ExhaustFan == other.ExhaustFan;
        }

        public static bool operator ==(AirHandlingUnit? left, AirHandlingUnit? right)
        {
            return EqualityComparer<AirHandlingUnit?>.Default.Equals(left, right);
        }

        public static bool operator !=(AirHandlingUnit? left, AirHandlingUnit? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), ZoneDelivery?.GetHashCode(), VentilationStrategy?.GetHashCode(), VentilationConfiguration?.GetHashCode(), RefrigerantType?.GetHashCode(), NominalHeatingCapacity?.GetHashCode(), NominalCoolingCapacity?.GetHashCode(), NetSensibleCoolingCapacity?.GetHashCode(), HumidificationMethod?.GetHashCode(), FilterType?.GetHashCode(), DischargeDuctworkConfiguration?.GetHashCode(), DehumidificationMethod?.GetHashCode(), AirflowModulation?.GetHashCode(), SupplyFan?.GetHashCode(), SecondaryCoolingMethod?.GetHashCode(), ReturnFan?.GetHashCode(), ReHeatingMethod?.GetHashCode(), PrimaryCoolingMethod?.GetHashCode(), PreHeatingMethod?.GetHashCode(), MixingBox?.GetHashCode(), ExhaustFan?.GetHashCode());
        }
    }
}