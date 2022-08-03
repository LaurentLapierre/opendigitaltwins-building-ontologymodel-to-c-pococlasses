using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.portfolio;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Portfolio : Collection, IEquatable<Portfolio>
    {
        public Portfolio()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Portfolio;1";
        [JsonIgnore]
        public PortfolioIncludesRelationshipCollection Includes { get; set; } = new PortfolioIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as Portfolio);
        }

        public bool Equals(Portfolio? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Portfolio? left, Portfolio? right)
        {
            return EqualityComparer<Portfolio?>.Default.Equals(left, right);
        }

        public static bool operator !=(Portfolio? left, Portfolio? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}