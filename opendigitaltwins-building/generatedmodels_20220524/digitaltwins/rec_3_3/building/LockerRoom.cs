using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class LockerRoom : Room, IEquatable<LockerRoom>
    {
        public LockerRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:LockerRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LockerRoom);
        }

        public bool Equals(LockerRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LockerRoom? left, LockerRoom? right)
        {
            return EqualityComparer<LockerRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(LockerRoom? left, LockerRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}