using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class ElectricityRoom : UtilitiesRoom, IEquatable<ElectricityRoom>
    {
        public ElectricityRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:ElectricityRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricityRoom);
        }

        public bool Equals(ElectricityRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ElectricityRoom? left, ElectricityRoom? right)
        {
            return EqualityComparer<ElectricityRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricityRoom? left, ElectricityRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}