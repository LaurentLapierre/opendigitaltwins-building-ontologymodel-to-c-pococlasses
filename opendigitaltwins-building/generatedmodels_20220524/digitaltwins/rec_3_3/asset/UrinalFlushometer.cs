using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class UrinalFlushometer : Urinal, IEquatable<UrinalFlushometer>
    {
        public UrinalFlushometer()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:UrinalFlushometer;1";
        [JsonPropertyName("waterPerFlush")]
        public double? WaterPerFlush { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as UrinalFlushometer);
        }

        public bool Equals(UrinalFlushometer? other)
        {
            return other is not null && base.Equals(other) && WaterPerFlush == other.WaterPerFlush;
        }

        public static bool operator ==(UrinalFlushometer? left, UrinalFlushometer? right)
        {
            return EqualityComparer<UrinalFlushometer?>.Default.Equals(left, right);
        }

        public static bool operator !=(UrinalFlushometer? left, UrinalFlushometer? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), WaterPerFlush?.GetHashCode());
        }
    }
}