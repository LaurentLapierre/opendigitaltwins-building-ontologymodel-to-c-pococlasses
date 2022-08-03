using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACCoolingMethod : Component, IEquatable<HVACCoolingMethod>
    {
        public HVACCoolingMethod()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACCoolingMethod;1";
        [JsonPropertyName("type")]
        public HVACCoolingMethodType? Type { get; set; }
        [JsonPropertyName("refrigerantType")]
        public string? RefrigerantType { get; set; }
        [JsonPropertyName("outsideDiameter")]
        public double? OutsideDiameter { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACCoolingMethod);
        }

        public bool Equals(HVACCoolingMethod? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && RefrigerantType == other.RefrigerantType && OutsideDiameter == other.OutsideDiameter;
        }

        public static bool operator ==(HVACCoolingMethod? left, HVACCoolingMethod? right)
        {
            return EqualityComparer<HVACCoolingMethod?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACCoolingMethod? left, HVACCoolingMethod? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), RefrigerantType?.GetHashCode(), OutsideDiameter?.GetHashCode());
        }
    }
}