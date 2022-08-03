using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class CookingRoom : FoodHandlingRoom, IEquatable<CookingRoom>
    {
        public CookingRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:CookingRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CookingRoom);
        }

        public bool Equals(CookingRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CookingRoom? left, CookingRoom? right)
        {
            return EqualityComparer<CookingRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(CookingRoom? left, CookingRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}