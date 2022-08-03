using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class CafeteriaRoom : FoodHandlingRoom, IEquatable<CafeteriaRoom>
    {
        public CafeteriaRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:CafeteriaRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CafeteriaRoom);
        }

        public bool Equals(CafeteriaRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CafeteriaRoom? left, CafeteriaRoom? right)
        {
            return EqualityComparer<CafeteriaRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(CafeteriaRoom? left, CafeteriaRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}