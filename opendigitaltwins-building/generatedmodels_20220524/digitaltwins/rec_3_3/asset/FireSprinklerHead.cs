using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FireSprinklerHead : SprinklerEquipment, IEquatable<FireSprinklerHead>
    {
        public FireSprinklerHead()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FireSprinklerHead;1";
        [JsonPropertyName("type")]
        public FireSprinklerHeadType? Type { get; set; }
        [JsonPropertyName("kFactorMetric")]
        public int? KFactorMetric { get; set; }
        [JsonPropertyName("kFactorImperial")]
        public int? KFactorImperial { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireSprinklerHead);
        }

        public bool Equals(FireSprinklerHead? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && KFactorMetric == other.KFactorMetric && KFactorImperial == other.KFactorImperial;
        }

        public static bool operator ==(FireSprinklerHead? left, FireSprinklerHead? right)
        {
            return EqualityComparer<FireSprinklerHead?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireSprinklerHead? left, FireSprinklerHead? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), KFactorMetric?.GetHashCode(), KFactorImperial?.GetHashCode());
        }
    }
}