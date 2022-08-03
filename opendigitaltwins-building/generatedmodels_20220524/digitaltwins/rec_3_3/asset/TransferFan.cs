using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class TransferFan : HVACFan, IEquatable<TransferFan>
    {
        public TransferFan()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:TransferFan;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as TransferFan);
        }

        public bool Equals(TransferFan? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(TransferFan? left, TransferFan? right)
        {
            return EqualityComparer<TransferFan?>.Default.Equals(left, right);
        }

        public static bool operator !=(TransferFan? left, TransferFan? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}