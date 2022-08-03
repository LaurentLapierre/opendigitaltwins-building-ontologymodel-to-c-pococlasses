using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class CondensingUnit : HVACEquipment, IEquatable<CondensingUnit>
    {
        public CondensingUnit()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:CondensingUnit;1";
        [JsonPropertyName("type")]
        public CondensingUnitType? Type { get; set; }
        [JsonPropertyName("refrigerantType")]
        public string? RefrigerantType { get; set; }
        [JsonPropertyName("nominalHeatingCapacity")]
        public double? NominalHeatingCapacity { get; set; }
        [JsonPropertyName("nominalCoolingCapacity")]
        public double? NominalCoolingCapacity { get; set; }
        [JsonPropertyName("netSensibleHeatingCapacity")]
        public double? NetSensibleHeatingCapacity { get; set; }
        [JsonPropertyName("netSensibleCoolingCapacity")]
        public double? NetSensibleCoolingCapacity { get; set; }
        [JsonPropertyName("eer")]
        public double? Eer { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as CondensingUnit);
        }

        public bool Equals(CondensingUnit? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && RefrigerantType == other.RefrigerantType && NominalHeatingCapacity == other.NominalHeatingCapacity && NominalCoolingCapacity == other.NominalCoolingCapacity && NetSensibleHeatingCapacity == other.NetSensibleHeatingCapacity && NetSensibleCoolingCapacity == other.NetSensibleCoolingCapacity && Eer == other.Eer;
        }

        public static bool operator ==(CondensingUnit? left, CondensingUnit? right)
        {
            return EqualityComparer<CondensingUnit?>.Default.Equals(left, right);
        }

        public static bool operator !=(CondensingUnit? left, CondensingUnit? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), RefrigerantType?.GetHashCode(), NominalHeatingCapacity?.GetHashCode(), NominalCoolingCapacity?.GetHashCode(), NetSensibleHeatingCapacity?.GetHashCode(), NetSensibleCoolingCapacity?.GetHashCode(), Eer?.GetHashCode());
        }
    }
}