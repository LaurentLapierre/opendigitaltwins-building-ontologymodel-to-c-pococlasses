using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class PersonalHygiene : Room, IEquatable<PersonalHygiene>
    {
        public PersonalHygiene()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:PersonalHygiene;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PersonalHygiene);
        }

        public bool Equals(PersonalHygiene? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PersonalHygiene? left, PersonalHygiene? right)
        {
            return EqualityComparer<PersonalHygiene?>.Default.Equals(left, right);
        }

        public static bool operator !=(PersonalHygiene? left, PersonalHygiene? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}