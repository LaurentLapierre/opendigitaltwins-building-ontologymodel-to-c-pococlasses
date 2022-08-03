using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class EthernetSwitch : DataNetworkEquipment, IEquatable<EthernetSwitch>
    {
        public EthernetSwitch()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:EthernetSwitch;1";
        [JsonPropertyName("numberOfPorts")]
        public int? NumberOfPorts { get; set; }
        [JsonPropertyName("heightRUs")]
        public int? HeightRUs { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as EthernetSwitch);
        }

        public bool Equals(EthernetSwitch? other)
        {
            return other is not null && base.Equals(other) && NumberOfPorts == other.NumberOfPorts && HeightRUs == other.HeightRUs;
        }

        public static bool operator ==(EthernetSwitch? left, EthernetSwitch? right)
        {
            return EqualityComparer<EthernetSwitch?>.Default.Equals(left, right);
        }

        public static bool operator !=(EthernetSwitch? left, EthernetSwitch? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), NumberOfPorts?.GetHashCode(), HeightRUs?.GetHashCode());
        }
    }
}