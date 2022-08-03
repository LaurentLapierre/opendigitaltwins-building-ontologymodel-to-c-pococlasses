using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Urinal : PlumbingFixture, IEquatable<Urinal>
    {
        public Urinal()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Urinal;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Urinal);
        }

        public bool Equals(Urinal? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Urinal? left, Urinal? right)
        {
            return EqualityComparer<Urinal?>.Default.Equals(left, right);
        }

        public static bool operator !=(Urinal? left, Urinal? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}