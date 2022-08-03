using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerHeatTracing : SprinklerEquipment, IEquatable<SprinklerHeatTracing>
    {
        public SprinklerHeatTracing()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerHeatTracing;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerHeatTracing);
        }

        public bool Equals(SprinklerHeatTracing? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SprinklerHeatTracing? left, SprinklerHeatTracing? right)
        {
            return EqualityComparer<SprinklerHeatTracing?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerHeatTracing? left, SprinklerHeatTracing? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}