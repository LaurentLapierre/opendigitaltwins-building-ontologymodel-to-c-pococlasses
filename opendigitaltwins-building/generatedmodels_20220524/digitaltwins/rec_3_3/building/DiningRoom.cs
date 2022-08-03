using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class DiningRoom : FoodHandlingRoom, IEquatable<DiningRoom>
    {
        public DiningRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:DiningRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DiningRoom);
        }

        public bool Equals(DiningRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DiningRoom? left, DiningRoom? right)
        {
            return EqualityComparer<DiningRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(DiningRoom? left, DiningRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}