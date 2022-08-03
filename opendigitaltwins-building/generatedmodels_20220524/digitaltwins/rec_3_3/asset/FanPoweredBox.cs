using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FanPoweredBox : VAVBox, IEquatable<FanPoweredBox>
    {
        public FanPoweredBox()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FanPoweredBox;1";
        [JsonPropertyName("configuration")]
        public FanPoweredBoxConfiguration? Configuration { get; set; }
        [JsonPropertyName("fan")]
        public Fan? Fan { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as FanPoweredBox);
        }

        public bool Equals(FanPoweredBox? other)
        {
            return other is not null && base.Equals(other) && Configuration == other.Configuration && Fan == other.Fan;
        }

        public static bool operator ==(FanPoweredBox? left, FanPoweredBox? right)
        {
            return EqualityComparer<FanPoweredBox?>.Default.Equals(left, right);
        }

        public static bool operator !=(FanPoweredBox? left, FanPoweredBox? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Configuration?.GetHashCode(), Fan?.GetHashCode());
        }
    }
}