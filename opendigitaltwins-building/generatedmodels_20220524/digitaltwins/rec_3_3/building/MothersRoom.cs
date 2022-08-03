using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class MothersRoom : Room, IEquatable<MothersRoom>
    {
        public MothersRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:MothersRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as MothersRoom);
        }

        public bool Equals(MothersRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MothersRoom? left, MothersRoom? right)
        {
            return EqualityComparer<MothersRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(MothersRoom? left, MothersRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}