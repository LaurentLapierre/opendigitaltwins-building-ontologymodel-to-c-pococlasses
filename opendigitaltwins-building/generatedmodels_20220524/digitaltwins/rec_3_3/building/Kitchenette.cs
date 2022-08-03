using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class Kitchenette : FoodHandlingRoom, IEquatable<Kitchenette>
    {
        public Kitchenette()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:Kitchenette;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Kitchenette);
        }

        public bool Equals(Kitchenette? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Kitchenette? left, Kitchenette? right)
        {
            return EqualityComparer<Kitchenette?>.Default.Equals(left, right);
        }

        public static bool operator !=(Kitchenette? left, Kitchenette? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}