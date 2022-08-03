using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class UtilitiesRoom : Room, IEquatable<UtilitiesRoom>
    {
        public UtilitiesRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:UtilitiesRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as UtilitiesRoom);
        }

        public bool Equals(UtilitiesRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(UtilitiesRoom? left, UtilitiesRoom? right)
        {
            return EqualityComparer<UtilitiesRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(UtilitiesRoom? left, UtilitiesRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}