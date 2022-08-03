using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class PharmacyRoom : HealthcareRoom, IEquatable<PharmacyRoom>
    {
        public PharmacyRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:PharmacyRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PharmacyRoom);
        }

        public bool Equals(PharmacyRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PharmacyRoom? left, PharmacyRoom? right)
        {
            return EqualityComparer<PharmacyRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(PharmacyRoom? left, PharmacyRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}