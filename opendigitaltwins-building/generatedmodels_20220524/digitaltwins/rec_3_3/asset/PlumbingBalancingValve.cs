using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingBalancingValve : PlumbingValve, IEquatable<PlumbingBalancingValve>
    {
        public PlumbingBalancingValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingBalancingValve;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingBalancingValve);
        }

        public bool Equals(PlumbingBalancingValve? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingBalancingValve? left, PlumbingBalancingValve? right)
        {
            return EqualityComparer<PlumbingBalancingValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingBalancingValve? left, PlumbingBalancingValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}