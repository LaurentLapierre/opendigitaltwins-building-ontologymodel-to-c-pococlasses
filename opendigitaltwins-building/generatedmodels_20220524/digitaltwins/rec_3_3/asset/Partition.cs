using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Partition : BarrierAsset, IEquatable<Partition>
    {
        public Partition()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Partition;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Partition);
        }

        public bool Equals(Partition? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Partition? left, Partition? right)
        {
            return EqualityComparer<Partition?>.Default.Equals(left, right);
        }

        public static bool operator !=(Partition? left, Partition? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}