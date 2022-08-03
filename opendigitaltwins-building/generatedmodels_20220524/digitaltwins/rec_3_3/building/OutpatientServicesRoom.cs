using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class OutpatientServicesRoom : HealthcareRoom, IEquatable<OutpatientServicesRoom>
    {
        public OutpatientServicesRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:OutpatientServicesRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OutpatientServicesRoom);
        }

        public bool Equals(OutpatientServicesRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OutpatientServicesRoom? left, OutpatientServicesRoom? right)
        {
            return EqualityComparer<OutpatientServicesRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(OutpatientServicesRoom? left, OutpatientServicesRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}