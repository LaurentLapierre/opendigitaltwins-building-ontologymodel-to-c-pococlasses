using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingTank : Tank, IEquatable<PlumbingTank>
    {
        public PlumbingTank()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingTank;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingTank);
        }

        public bool Equals(PlumbingTank? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingTank? left, PlumbingTank? right)
        {
            return EqualityComparer<PlumbingTank?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingTank? left, PlumbingTank? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}