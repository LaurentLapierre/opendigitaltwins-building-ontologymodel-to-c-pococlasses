using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACBalancingValve : HVACValve, IEquatable<HVACBalancingValve>
    {
        public HVACBalancingValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACBalancingValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACBalancingValve);
        }

        public bool Equals(HVACBalancingValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACBalancingValve? left, HVACBalancingValve? right)
        {
            return EqualityComparer<HVACBalancingValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACBalancingValve? left, HVACBalancingValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}