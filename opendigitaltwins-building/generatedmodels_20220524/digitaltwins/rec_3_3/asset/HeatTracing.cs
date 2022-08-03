using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HeatTracing : Component, IEquatable<HeatTracing>
    {
        public HeatTracing()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HeatTracing;1";
        [JsonPropertyName("type")]
        public HeatTracingType? Type { get; set; }
        [JsonPropertyName("powerDensity")]
        public double? PowerDensity { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as HeatTracing);
        }

        public bool Equals(HeatTracing? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && PowerDensity == other.PowerDensity;
        }

        public static bool operator ==(HeatTracing? left, HeatTracing? right)
        {
            return EqualityComparer<HeatTracing?>.Default.Equals(left, right);
        }

        public static bool operator !=(HeatTracing? left, HeatTracing? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), PowerDensity?.GetHashCode());
        }
    }
}