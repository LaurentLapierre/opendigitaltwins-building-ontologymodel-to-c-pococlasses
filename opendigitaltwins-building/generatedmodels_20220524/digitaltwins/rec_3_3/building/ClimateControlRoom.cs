using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class ClimateControlRoom : UtilitiesRoom, IEquatable<ClimateControlRoom>
    {
        public ClimateControlRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:ClimateControlRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ClimateControlRoom);
        }

        public bool Equals(ClimateControlRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ClimateControlRoom? left, ClimateControlRoom? right)
        {
            return EqualityComparer<ClimateControlRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(ClimateControlRoom? left, ClimateControlRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}