using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FanPoweredBoxReheat : FanPoweredBox, IEquatable<FanPoweredBoxReheat>
    {
        public FanPoweredBoxReheat()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FanPoweredBoxReheat;1";
        [JsonPropertyName("nominalHeatingCapacity")]
        public double? NominalHeatingCapacity { get; set; }
        [JsonPropertyName("reHeatingMethod")]
        public HVACHeatingMethod? ReHeatingMethod { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as FanPoweredBoxReheat);
        }

        public bool Equals(FanPoweredBoxReheat? other)
        {
            return other is not null && base.Equals(other) && NominalHeatingCapacity == other.NominalHeatingCapacity && ReHeatingMethod == other.ReHeatingMethod;
        }

        public static bool operator ==(FanPoweredBoxReheat? left, FanPoweredBoxReheat? right)
        {
            return EqualityComparer<FanPoweredBoxReheat?>.Default.Equals(left, right);
        }

        public static bool operator !=(FanPoweredBoxReheat? left, FanPoweredBoxReheat? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), NominalHeatingCapacity?.GetHashCode(), ReHeatingMethod?.GetHashCode());
        }
    }
}