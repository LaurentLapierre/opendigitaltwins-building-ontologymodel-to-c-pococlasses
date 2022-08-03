using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class EthernetSwitchPort : DataNetworkEquipment, IEquatable<EthernetSwitchPort>
    {
        public EthernetSwitchPort()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:EthernetSwitchPort;1";
        [JsonPropertyName("portSpeed")]
        public string? PortSpeed { get; set; }
        [JsonPropertyName("poeType")]
        public int? PoeType { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as EthernetSwitchPort);
        }

        public bool Equals(EthernetSwitchPort? other)
        {
            return other is not null && base.Equals(other) && PortSpeed == other.PortSpeed && PoeType == other.PoeType;
        }

        public static bool operator ==(EthernetSwitchPort? left, EthernetSwitchPort? right)
        {
            return EqualityComparer<EthernetSwitchPort?>.Default.Equals(left, right);
        }

        public static bool operator !=(EthernetSwitchPort? left, EthernetSwitchPort? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PortSpeed?.GetHashCode(), PoeType?.GetHashCode());
        }
    }
}