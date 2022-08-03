using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class WirelessAccessPoint : DataNetworkEquipment, IEquatable<WirelessAccessPoint>
    {
        public WirelessAccessPoint()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:WirelessAccessPoint;1";
        [JsonPropertyName("type")]
        public WirelessAccessPointType? Type { get; set; }
        [JsonPropertyName("mounting")]
        public WirelessAccessPointMounting? Mounting { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as WirelessAccessPoint);
        }

        public bool Equals(WirelessAccessPoint? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && Mounting == other.Mounting;
        }

        public static bool operator ==(WirelessAccessPoint? left, WirelessAccessPoint? right)
        {
            return EqualityComparer<WirelessAccessPoint?>.Default.Equals(left, right);
        }

        public static bool operator !=(WirelessAccessPoint? left, WirelessAccessPoint? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), Mounting?.GetHashCode());
        }
    }
}