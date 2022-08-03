using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class OperatingRoom : HealthcareRoom, IEquatable<OperatingRoom>
    {
        public OperatingRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:OperatingRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OperatingRoom);
        }

        public bool Equals(OperatingRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OperatingRoom? left, OperatingRoom? right)
        {
            return EqualityComparer<OperatingRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(OperatingRoom? left, OperatingRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}