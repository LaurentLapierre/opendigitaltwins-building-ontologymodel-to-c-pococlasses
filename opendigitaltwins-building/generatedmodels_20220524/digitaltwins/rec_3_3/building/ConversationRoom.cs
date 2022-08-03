using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class ConversationRoom : Room, IEquatable<ConversationRoom>
    {
        public ConversationRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:ConversationRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ConversationRoom);
        }

        public bool Equals(ConversationRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ConversationRoom? left, ConversationRoom? right)
        {
            return EqualityComparer<ConversationRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(ConversationRoom? left, ConversationRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}