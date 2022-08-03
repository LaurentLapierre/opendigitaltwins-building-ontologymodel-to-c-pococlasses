using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingStorageTank : PlumbingTank, IEquatable<PlumbingStorageTank>
    {
        public PlumbingStorageTank()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingStorageTank;1";
        [JsonPropertyName("type")]
        public PlumbingStorageTankType? Type { get; set; }
        [JsonPropertyName("arrangement")]
        public PlumbingStorageTankArrangement? Arrangement { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingStorageTank);
        }

        public bool Equals(PlumbingStorageTank? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && Arrangement == other.Arrangement;
        }

        public static bool operator ==(PlumbingStorageTank? left, PlumbingStorageTank? right)
        {
            return EqualityComparer<PlumbingStorageTank?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingStorageTank? left, PlumbingStorageTank? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), Arrangement?.GetHashCode());
        }
    }
}