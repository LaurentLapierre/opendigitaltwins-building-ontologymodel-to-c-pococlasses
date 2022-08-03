using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACFan : HVACEquipment, IEquatable<HVACFan>
    {
        public HVACFan()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACFan;1";
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("fan")]
        public Fan? Fan { get; set; }
        [JsonPropertyName("ductInlet")]
        public DuctConnection? DuctInlet { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACFan);
        }

        public bool Equals(HVACFan? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && Fan == other.Fan && DuctInlet == other.DuctInlet;
        }

        public static bool operator ==(HVACFan? left, HVACFan? right)
        {
            return EqualityComparer<HVACFan?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACFan? left, HVACFan? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), Fan?.GetHashCode(), DuctInlet?.GetHashCode());
        }
    }
}