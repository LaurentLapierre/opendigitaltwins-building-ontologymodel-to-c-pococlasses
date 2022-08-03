using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACTank : Tank, IEquatable<HVACTank>
    {
        public HVACTank()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACTank;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACTank);
        }

        public bool Equals(HVACTank? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACTank? left, HVACTank? right)
        {
            return EqualityComparer<HVACTank?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACTank? left, HVACTank? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}