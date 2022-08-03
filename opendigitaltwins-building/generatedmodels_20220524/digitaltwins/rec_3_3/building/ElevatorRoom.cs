using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class ElevatorRoom : Room, IEquatable<ElevatorRoom>
    {
        public ElevatorRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:ElevatorRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElevatorRoom);
        }

        public bool Equals(ElevatorRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ElevatorRoom? left, ElevatorRoom? right)
        {
            return EqualityComparer<ElevatorRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElevatorRoom? left, ElevatorRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}