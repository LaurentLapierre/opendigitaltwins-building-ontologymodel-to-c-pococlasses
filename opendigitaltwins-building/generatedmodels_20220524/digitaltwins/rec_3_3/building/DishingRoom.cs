using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class DishingRoom : FoodHandlingRoom, IEquatable<DishingRoom>
    {
        public DishingRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:DishingRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DishingRoom);
        }

        public bool Equals(DishingRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DishingRoom? left, DishingRoom? right)
        {
            return EqualityComparer<DishingRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(DishingRoom? left, DishingRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}