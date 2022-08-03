using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class StaffRoom : Room, IEquatable<StaffRoom>
    {
        public StaffRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:StaffRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as StaffRoom);
        }

        public bool Equals(StaffRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(StaffRoom? left, StaffRoom? right)
        {
            return EqualityComparer<StaffRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(StaffRoom? left, StaffRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}