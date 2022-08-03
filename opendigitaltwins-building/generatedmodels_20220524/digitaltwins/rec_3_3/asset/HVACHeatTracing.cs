using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACHeatTracing : HeatTracing, IEquatable<HVACHeatTracing>
    {
        public HVACHeatTracing()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACHeatTracing;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACHeatTracing);
        }

        public bool Equals(HVACHeatTracing? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACHeatTracing? left, HVACHeatTracing? right)
        {
            return EqualityComparer<HVACHeatTracing?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACHeatTracing? left, HVACHeatTracing? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}