using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class AirFilter : HVACEquipment, IEquatable<AirFilter>
    {
        public AirFilter()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:AirFilter;1";
        [JsonPropertyName("fan")]
        public Fan? Fan { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as AirFilter);
        }

        public bool Equals(AirFilter? other)
        {
            return other is not null && base.Equals(other) && Fan == other.Fan;
        }

        public static bool operator ==(AirFilter? left, AirFilter? right)
        {
            return EqualityComparer<AirFilter?>.Default.Equals(left, right);
        }

        public static bool operator !=(AirFilter? left, AirFilter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Fan?.GetHashCode());
        }
    }
}