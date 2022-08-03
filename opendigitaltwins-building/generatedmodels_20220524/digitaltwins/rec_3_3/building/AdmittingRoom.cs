using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class AdmittingRoom : HealthcareRoom, IEquatable<AdmittingRoom>
    {
        public AdmittingRoom()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:AdmittingRoom;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as AdmittingRoom);
        }

        public bool Equals(AdmittingRoom? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(AdmittingRoom? left, AdmittingRoom? right)
        {
            return EqualityComparer<AdmittingRoom?>.Default.Equals(left, right);
        }

        public static bool operator !=(AdmittingRoom? left, AdmittingRoom? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}