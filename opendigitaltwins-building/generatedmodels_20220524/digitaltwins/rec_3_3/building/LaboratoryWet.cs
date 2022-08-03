using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class LaboratoryWet : Laboratory, IEquatable<LaboratoryWet>
    {
        public LaboratoryWet()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:LaboratoryWet;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LaboratoryWet);
        }

        public bool Equals(LaboratoryWet? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LaboratoryWet? left, LaboratoryWet? right)
        {
            return EqualityComparer<LaboratoryWet?>.Default.Equals(left, right);
        }

        public static bool operator !=(LaboratoryWet? left, LaboratoryWet? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}