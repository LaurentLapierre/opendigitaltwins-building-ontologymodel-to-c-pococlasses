using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class Toilet : PersonalHygiene, IEquatable<Toilet>
    {
        public Toilet()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:Toilet;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Toilet);
        }

        public bool Equals(Toilet? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Toilet? left, Toilet? right)
        {
            return EqualityComparer<Toilet?>.Default.Equals(left, right);
        }

        public static bool operator !=(Toilet? left, Toilet? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}