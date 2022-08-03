using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class TelecommunicationRoom : CableRoom, IEquatable<TelecommunicationRoom>
    {
        public TelecommunicationRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:TelecommunicationRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as TelecommunicationRoom);
        }

        public bool Equals(TelecommunicationRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(TelecommunicationRoom? left, TelecommunicationRoom? right)
        {
            return EqualityComparer<TelecommunicationRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(TelecommunicationRoom? left, TelecommunicationRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}