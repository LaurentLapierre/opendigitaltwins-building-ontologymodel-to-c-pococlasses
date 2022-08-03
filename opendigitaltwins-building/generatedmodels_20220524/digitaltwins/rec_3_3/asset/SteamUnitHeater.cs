using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SteamUnitHeater : UnitHeater, IEquatable<SteamUnitHeater>
    {
        public SteamUnitHeater()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SteamUnitHeater;1";
        [JsonPropertyName("condensate")]
        public int? Condensate { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as SteamUnitHeater);
        }

        public bool Equals(SteamUnitHeater? other)
        {
            return other is not null && base.Equals(other) && Condensate == other.Condensate;
        }

        public static bool operator ==(SteamUnitHeater? left, SteamUnitHeater? right)
        {
            return EqualityComparer<SteamUnitHeater?>.Default.Equals(left, right);
        }

        public static bool operator !=(SteamUnitHeater? left, SteamUnitHeater? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Condensate?.GetHashCode());
        }
    }
}