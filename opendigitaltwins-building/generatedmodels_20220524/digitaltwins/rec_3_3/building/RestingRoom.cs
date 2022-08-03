using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class RestingRoom : Room, IEquatable<RestingRoom>
    {
        public RestingRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:RestingRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as RestingRoom);
        }

        public bool Equals(RestingRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(RestingRoom? left, RestingRoom? right)
        {
            return EqualityComparer<RestingRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(RestingRoom? left, RestingRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}