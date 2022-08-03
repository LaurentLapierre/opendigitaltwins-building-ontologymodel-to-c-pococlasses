using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class ShelterGasLock : Shelter, IEquatable<ShelterGasLock>
    {
        public ShelterGasLock()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:ShelterGasLock;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ShelterGasLock);
        }

        public bool Equals(ShelterGasLock? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ShelterGasLock? left, ShelterGasLock? right)
        {
            return EqualityComparer<ShelterGasLock?>.Default.Equals(left, right);
        }

        public static bool operator !=(ShelterGasLock? left, ShelterGasLock? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}