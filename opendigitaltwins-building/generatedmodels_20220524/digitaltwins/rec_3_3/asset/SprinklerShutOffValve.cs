using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerShutOffValve : SprinklerValve, IEquatable<SprinklerShutOffValve>
    {
        public SprinklerShutOffValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerShutOffValve;1";
        [JsonPropertyName("type")]
        public SprinklerShutOffValveType? Type { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerShutOffValve);
        }

        public bool Equals(SprinklerShutOffValve? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type;
        }

        public static bool operator ==(SprinklerShutOffValve? left, SprinklerShutOffValve? right)
        {
            return EqualityComparer<SprinklerShutOffValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerShutOffValve? left, SprinklerShutOffValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode());
        }
    }
}