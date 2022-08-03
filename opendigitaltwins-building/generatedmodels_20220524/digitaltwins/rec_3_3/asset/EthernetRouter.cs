using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class EthernetRouter : DataNetworkEquipment, IEquatable<EthernetRouter>
    {
        public EthernetRouter()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:EthernetRouter;1";
        [JsonPropertyName("numberOfPorts")]
        public int? NumberOfPorts { get; set; }
        [JsonPropertyName("heightRUs")]
        public int? HeightRUs { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as EthernetRouter);
        }

        public bool Equals(EthernetRouter? other)
        {
            return other is not null && base.Equals(other) && NumberOfPorts == other.NumberOfPorts && HeightRUs == other.HeightRUs;
        }

        public static bool operator ==(EthernetRouter? left, EthernetRouter? right)
        {
            return EqualityComparer<EthernetRouter?>.Default.Equals(left, right);
        }

        public static bool operator !=(EthernetRouter? left, EthernetRouter? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), NumberOfPorts?.GetHashCode(), HeightRUs?.GetHashCode());
        }
    }
}