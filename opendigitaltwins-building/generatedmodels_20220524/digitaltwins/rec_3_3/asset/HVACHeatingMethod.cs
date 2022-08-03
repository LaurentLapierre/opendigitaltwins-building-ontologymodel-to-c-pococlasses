using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACHeatingMethod : Component, IEquatable<HVACHeatingMethod>
    {
        public HVACHeatingMethod()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACHeatingMethod;1";
        [JsonPropertyName("type")]
        public HVACHeatingMethodType? Type { get; set; }
        [JsonPropertyName("outsideDiameter")]
        public double? OutsideDiameter { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACHeatingMethod);
        }

        public bool Equals(HVACHeatingMethod? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && OutsideDiameter == other.OutsideDiameter;
        }

        public static bool operator ==(HVACHeatingMethod? left, HVACHeatingMethod? right)
        {
            return EqualityComparer<HVACHeatingMethod?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACHeatingMethod? left, HVACHeatingMethod? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), OutsideDiameter?.GetHashCode());
        }
    }
}