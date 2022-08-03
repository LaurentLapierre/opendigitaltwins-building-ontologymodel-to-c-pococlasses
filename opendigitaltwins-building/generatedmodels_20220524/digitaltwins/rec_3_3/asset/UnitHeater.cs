using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class UnitHeater : HVACEquipment, IEquatable<UnitHeater>
    {
        public UnitHeater()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:UnitHeater;1";
        [JsonPropertyName("type")]
        public UnitHeaterType? Type { get; set; }
        [JsonPropertyName("nominalHeatingCapacity")]
        public double? NominalHeatingCapacity { get; set; }
        [JsonPropertyName("heatingMethod")]
        public HVACHeatingMethod? HeatingMethod { get; set; }
        [JsonPropertyName("fan")]
        public Fan? Fan { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as UnitHeater);
        }

        public bool Equals(UnitHeater? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && NominalHeatingCapacity == other.NominalHeatingCapacity && HeatingMethod == other.HeatingMethod && Fan == other.Fan;
        }

        public static bool operator ==(UnitHeater? left, UnitHeater? right)
        {
            return EqualityComparer<UnitHeater?>.Default.Equals(left, right);
        }

        public static bool operator !=(UnitHeater? left, UnitHeater? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), NominalHeatingCapacity?.GetHashCode(), HeatingMethod?.GetHashCode(), Fan?.GetHashCode());
        }
    }
}