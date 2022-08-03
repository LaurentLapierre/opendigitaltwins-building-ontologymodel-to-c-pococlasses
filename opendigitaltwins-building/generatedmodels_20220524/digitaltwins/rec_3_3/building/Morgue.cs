using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class Morgue : HealthcareRoom, IEquatable<Morgue>
    {
        public Morgue()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:Morgue;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Morgue);
        }

        public bool Equals(Morgue? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Morgue? left, Morgue? right)
        {
            return EqualityComparer<Morgue?>.Default.Equals(left, right);
        }

        public static bool operator !=(Morgue? left, Morgue? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}