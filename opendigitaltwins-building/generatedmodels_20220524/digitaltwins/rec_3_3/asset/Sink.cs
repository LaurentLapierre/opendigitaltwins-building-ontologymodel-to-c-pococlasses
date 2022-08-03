using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Sink : PlumbingFixture, IEquatable<Sink>
    {
        public Sink()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Sink;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Sink);
        }

        public bool Equals(Sink? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Sink? left, Sink? right)
        {
            return EqualityComparer<Sink?>.Default.Equals(left, right);
        }

        public static bool operator !=(Sink? left, Sink? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}