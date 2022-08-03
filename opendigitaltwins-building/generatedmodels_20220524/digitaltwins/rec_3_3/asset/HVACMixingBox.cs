using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACMixingBox : Component, IEquatable<HVACMixingBox>
    {
        public HVACMixingBox()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACMixingBox;1";
        [JsonPropertyName("economizer")]
        public bool? Economizer { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACMixingBox);
        }

        public bool Equals(HVACMixingBox? other)
        {
            return other is not null && base.Equals(other) && Economizer == other.Economizer;
        }

        public static bool operator ==(HVACMixingBox? left, HVACMixingBox? right)
        {
            return EqualityComparer<HVACMixingBox?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACMixingBox? left, HVACMixingBox? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Economizer?.GetHashCode());
        }
    }
}