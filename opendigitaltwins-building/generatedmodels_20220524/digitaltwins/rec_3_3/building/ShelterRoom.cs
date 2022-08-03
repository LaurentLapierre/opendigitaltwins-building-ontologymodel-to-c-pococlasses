using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class ShelterRoom : Shelter, IEquatable<ShelterRoom>
    {
        public ShelterRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:ShelterRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ShelterRoom);
        }

        public bool Equals(ShelterRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ShelterRoom? left, ShelterRoom? right)
        {
            return EqualityComparer<ShelterRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(ShelterRoom? left, ShelterRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}