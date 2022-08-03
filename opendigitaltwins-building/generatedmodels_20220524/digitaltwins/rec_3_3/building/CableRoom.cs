using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class CableRoom : UtilitiesRoom, IEquatable<CableRoom>
    {
        public CableRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:CableRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as CableRoom);
        }

        public bool Equals(CableRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(CableRoom? left, CableRoom? right)
        {
            return EqualityComparer<CableRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(CableRoom? left, CableRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}