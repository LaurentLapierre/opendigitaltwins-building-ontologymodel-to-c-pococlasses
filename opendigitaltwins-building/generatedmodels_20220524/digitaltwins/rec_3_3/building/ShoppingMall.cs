using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class ShoppingMall : Building, IEquatable<ShoppingMall>
    {
        public ShoppingMall()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:ShoppingMall;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ShoppingMall);
        }

        public bool Equals(ShoppingMall? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ShoppingMall? left, ShoppingMall? right)
        {
            return EqualityComparer<ShoppingMall?>.Default.Equals(left, right);
        }

        public static bool operator !=(ShoppingMall? left, ShoppingMall? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}