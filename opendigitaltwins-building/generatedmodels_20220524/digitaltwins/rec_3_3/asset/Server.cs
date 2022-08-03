using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Server : ICTHardware, IEquatable<Server>
    {
        public Server()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Server;1";
        [JsonPropertyName("numberOfPorts")]
        public int? NumberOfPorts { get; set; }
        [JsonPropertyName("heightRUs")]
        public int? HeightRUs { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Server);
        }

        public bool Equals(Server? other)
        {
            return other is not null && base.Equals(other) && NumberOfPorts == other.NumberOfPorts && HeightRUs == other.HeightRUs;
        }

        public static bool operator ==(Server? left, Server? right)
        {
            return EqualityComparer<Server?>.Default.Equals(left, right);
        }

        public static bool operator !=(Server? left, Server? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), NumberOfPorts?.GetHashCode(), HeightRUs?.GetHashCode());
        }
    }
}