using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.apartment;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Apartment : SpaceCollection, IEquatable<Apartment>
    {
        public Apartment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Apartment;1";
        [JsonIgnore]
        public ApartmentIncludesRelationshipCollection Includes { get; set; } = new ApartmentIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as Apartment);
        }

        public bool Equals(Apartment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Apartment? left, Apartment? right)
        {
            return EqualityComparer<Apartment?>.Default.Equals(left, right);
        }

        public static bool operator !=(Apartment? left, Apartment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}