using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingExpansionTank : PlumbingTank, IEquatable<PlumbingExpansionTank>
    {
        public PlumbingExpansionTank()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingExpansionTank;1";
        [JsonPropertyName("type")]
        public PlumbingExpansionTankType? Type { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingExpansionTank);
        }

        public bool Equals(PlumbingExpansionTank? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type;
        }

        public static bool operator ==(PlumbingExpansionTank? left, PlumbingExpansionTank? right)
        {
            return EqualityComparer<PlumbingExpansionTank?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingExpansionTank? left, PlumbingExpansionTank? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode());
        }
    }
}