using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class DuctConnection : Component, IEquatable<DuctConnection>
    {
        public DuctConnection()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:DuctConnection;1";
        [JsonPropertyName("size")]
        public double? Size { get; set; }
        [JsonPropertyName("shape")]
        public DuctConnectionShape? Shape { get; set; }
        [JsonPropertyName("configuration")]
        public DuctConnectionConfiguration? Configuration { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as DuctConnection);
        }

        public bool Equals(DuctConnection? other)
        {
            return other is not null && base.Equals(other) && Size == other.Size && Shape == other.Shape && Configuration == other.Configuration;
        }

        public static bool operator ==(DuctConnection? left, DuctConnection? right)
        {
            return EqualityComparer<DuctConnection?>.Default.Equals(left, right);
        }

        public static bool operator !=(DuctConnection? left, DuctConnection? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Size?.GetHashCode(), Shape?.GetHashCode(), Configuration?.GetHashCode());
        }
    }
}