using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class ShowerRoom : PersonalHygiene, IEquatable<ShowerRoom>
    {
        public ShowerRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:ShowerRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ShowerRoom);
        }

        public bool Equals(ShowerRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ShowerRoom? left, ShowerRoom? right)
        {
            return EqualityComparer<ShowerRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(ShowerRoom? left, ShowerRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}