using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class GroupRoom : EducationalRoom, IEquatable<GroupRoom>
    {
        public GroupRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:GroupRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as GroupRoom);
        }

        public bool Equals(GroupRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(GroupRoom? left, GroupRoom? right)
        {
            return EqualityComparer<GroupRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(GroupRoom? left, GroupRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}