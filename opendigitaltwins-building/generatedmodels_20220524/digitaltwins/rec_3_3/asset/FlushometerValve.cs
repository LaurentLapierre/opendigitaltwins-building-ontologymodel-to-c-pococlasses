using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.flushometervalve;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FlushometerValve : PlumbingFixture, IEquatable<FlushometerValve>
    {
        public FlushometerValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FlushometerValve;1";
        [JsonPropertyName("waterPerFlush")]
        public double? WaterPerFlush { get; set; }
        [JsonPropertyName("type")]
        public FlushometerValveType? Type { get; set; }
        [JsonPropertyName("technology")]
        public FlushometerValveTechnology? Technology { get; set; }
        [JsonIgnore]
        public FlushometerValveMountedOnRelationshipCollection MountedOn { get; set; } = new FlushometerValveMountedOnRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as FlushometerValve);
        }

        public bool Equals(FlushometerValve? other)
        {
            return other is not null && base.Equals(other) && WaterPerFlush == other.WaterPerFlush && Type == other.Type && Technology == other.Technology;
        }

        public static bool operator ==(FlushometerValve? left, FlushometerValve? right)
        {
            return EqualityComparer<FlushometerValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(FlushometerValve? left, FlushometerValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), WaterPerFlush?.GetHashCode(), Type?.GetHashCode(), Technology?.GetHashCode());
        }
    }
}