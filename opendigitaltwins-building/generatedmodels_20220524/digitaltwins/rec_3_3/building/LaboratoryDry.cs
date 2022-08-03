using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.building
{

    public class LaboratoryDry : Laboratory, IEquatable<LaboratoryDry>
    {
        public LaboratoryDry()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:building:LaboratoryDry;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as LaboratoryDry);
        }

        public bool Equals(LaboratoryDry? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LaboratoryDry? left, LaboratoryDry? right)
        {
            return EqualityComparer<LaboratoryDry?>.Default.Equals(left, right);
        }

        public static bool operator !=(LaboratoryDry? left, LaboratoryDry? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}