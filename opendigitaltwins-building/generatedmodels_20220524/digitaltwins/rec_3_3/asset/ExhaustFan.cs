using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ExhaustFan : HVACFan, IEquatable<ExhaustFan>
    {
        public ExhaustFan()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ExhaustFan;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ExhaustFan);
        }

        public bool Equals(ExhaustFan? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ExhaustFan? left, ExhaustFan? right)
        {
            return EqualityComparer<ExhaustFan?>.Default.Equals(left, right);
        }

        public static bool operator !=(ExhaustFan? left, ExhaustFan? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}