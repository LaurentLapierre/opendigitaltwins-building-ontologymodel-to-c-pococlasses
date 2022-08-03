using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.agents
{

    public class Company : Organization, IEquatable<Company>
    {
        public Company()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:agents:Company;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as Company);
        }

        public bool Equals(Company? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Company? left, Company? right)
        {
            return EqualityComparer<Company?>.Default.Equals(left, right);
        }

        public static bool operator !=(Company? left, Company? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}