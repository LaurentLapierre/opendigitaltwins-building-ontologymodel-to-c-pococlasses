using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Drain : PlumbingEquipment, IEquatable<Drain>
    {
        public Drain()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Drain;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Drain);
        }

        public bool Equals(Drain? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Drain? left, Drain? right)
        {
            return EqualityComparer<Drain?>.Default.Equals(left, right);
        }

        public static bool operator !=(Drain? left, Drain? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}