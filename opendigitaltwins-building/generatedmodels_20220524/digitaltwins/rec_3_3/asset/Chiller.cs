using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Chiller : HVACEquipment, IEquatable<Chiller>
    {
        public Chiller()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Chiller;1";
        [JsonPropertyName("type")]
        public ChillerType? Type { get; set; }
        [JsonPropertyName("refrigerantType")]
        public string? RefrigerantType { get; set; }
        [JsonPropertyName("nominalCoolingCapacity")]
        public double? NominalCoolingCapacity { get; set; }
        [JsonPropertyName("netSensibleCoolingCapacity")]
        public double? NetSensibleCoolingCapacity { get; set; }
        [JsonPropertyName("compressorType")]
        public ChillerCompressorType? CompressorType { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Chiller);
        }

        public bool Equals(Chiller? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && RefrigerantType == other.RefrigerantType && NominalCoolingCapacity == other.NominalCoolingCapacity && NetSensibleCoolingCapacity == other.NetSensibleCoolingCapacity && CompressorType == other.CompressorType;
        }

        public static bool operator ==(Chiller? left, Chiller? right)
        {
            return EqualityComparer<Chiller?>.Default.Equals(left, right);
        }

        public static bool operator !=(Chiller? left, Chiller? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), RefrigerantType?.GetHashCode(), NominalCoolingCapacity?.GetHashCode(), NetSensibleCoolingCapacity?.GetHashCode(), CompressorType?.GetHashCode());
        }
    }
}