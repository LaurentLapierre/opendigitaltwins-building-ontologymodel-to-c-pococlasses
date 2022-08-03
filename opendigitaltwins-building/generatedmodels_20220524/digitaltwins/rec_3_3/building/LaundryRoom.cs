using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class LaundryRoom : Room, IEquatable<LaundryRoom>
    {
        public LaundryRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:LaundryRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LaundryRoom);
        }

        public bool Equals(LaundryRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LaundryRoom? left, LaundryRoom? right)
        {
            return EqualityComparer<LaundryRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(LaundryRoom? left, LaundryRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}