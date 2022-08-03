using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Cogenerator : Generator, IEquatable<Cogenerator>
    {
        public Cogenerator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Cogenerator;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Cogenerator);
        }

        public bool Equals(Cogenerator? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Cogenerator? left, Cogenerator? right)
        {
            return EqualityComparer<Cogenerator?>.Default.Equals(left, right);
        }

        public static bool operator !=(Cogenerator? left, Cogenerator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}