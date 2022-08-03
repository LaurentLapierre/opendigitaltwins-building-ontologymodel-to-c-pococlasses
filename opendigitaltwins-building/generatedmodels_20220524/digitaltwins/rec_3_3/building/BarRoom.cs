using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class BarRoom : FoodHandlingRoom, IEquatable<BarRoom>
    {
        public BarRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:BarRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as BarRoom);
        }

        public bool Equals(BarRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(BarRoom? left, BarRoom? right)
        {
            return EqualityComparer<BarRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(BarRoom? left, BarRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}