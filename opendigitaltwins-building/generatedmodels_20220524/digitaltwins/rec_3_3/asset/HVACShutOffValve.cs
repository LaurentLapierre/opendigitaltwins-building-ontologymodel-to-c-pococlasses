using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACShutOffValve : HVACValve, IEquatable<HVACShutOffValve>
    {
        public HVACShutOffValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACShutOffValve;1";
        [JsonPropertyName("type")]
        public HVACShutOffValveType? Type { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACShutOffValve);
        }

        public bool Equals(HVACShutOffValve? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type;
        }

        public static bool operator ==(HVACShutOffValve? left, HVACShutOffValve? right)
        {
            return EqualityComparer<HVACShutOffValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACShutOffValve? left, HVACShutOffValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode());
        }
    }
}