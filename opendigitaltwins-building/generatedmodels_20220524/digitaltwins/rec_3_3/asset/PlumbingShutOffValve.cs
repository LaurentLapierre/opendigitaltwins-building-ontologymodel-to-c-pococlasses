using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingShutOffValve : PlumbingValve, IEquatable<PlumbingShutOffValve>
    {
        public PlumbingShutOffValve()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingShutOffValve;1";
        [JsonPropertyName("type")]
        public PlumbingShutOffValveType? Type { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingShutOffValve);
        }

        public bool Equals(PlumbingShutOffValve? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type;
        }

        public static bool operator ==(PlumbingShutOffValve? left, PlumbingShutOffValve? right)
        {
            return EqualityComparer<PlumbingShutOffValve?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingShutOffValve? left, PlumbingShutOffValve? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode());
        }
    }
}