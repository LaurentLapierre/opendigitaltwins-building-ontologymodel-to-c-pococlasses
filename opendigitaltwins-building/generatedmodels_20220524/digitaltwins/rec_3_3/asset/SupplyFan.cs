using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SupplyFan : HVACFan, IEquatable<SupplyFan>
    {
        public SupplyFan()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SupplyFan;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as SupplyFan);
        }

        public bool Equals(SupplyFan? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SupplyFan? left, SupplyFan? right)
        {
            return EqualityComparer<SupplyFan?>.Default.Equals(left, right);
        }

        public static bool operator !=(SupplyFan? left, SupplyFan? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}