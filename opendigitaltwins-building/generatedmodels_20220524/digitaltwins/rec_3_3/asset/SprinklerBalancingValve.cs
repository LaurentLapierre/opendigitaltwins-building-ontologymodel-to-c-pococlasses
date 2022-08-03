using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SprinklerBalancingValve : SprinklerValve, IEquatable<SprinklerBalancingValve>
    {
        public SprinklerBalancingValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SprinklerBalancingValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SprinklerBalancingValve);
        }

        public bool Equals(SprinklerBalancingValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SprinklerBalancingValve? left, SprinklerBalancingValve? right)
        {
            return EqualityComparer<SprinklerBalancingValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(SprinklerBalancingValve? left, SprinklerBalancingValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}