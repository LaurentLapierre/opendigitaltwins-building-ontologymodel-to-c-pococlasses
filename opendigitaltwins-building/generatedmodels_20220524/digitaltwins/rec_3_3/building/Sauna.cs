using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class Sauna : PersonalHygiene, IEquatable<Sauna>
    {
        public Sauna()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:Sauna;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Sauna);
        }

        public bool Equals(Sauna? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Sauna? left, Sauna? right)
        {
            return EqualityComparer<Sauna?>.Default.Equals(left, right);
        }

        public static bool operator !=(Sauna? left, Sauna? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}