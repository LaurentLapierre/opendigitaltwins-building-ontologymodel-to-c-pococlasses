using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.addressing;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Land : Space, IEquatable<Land>
    {
        public Land()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Land;1";
        [JsonPropertyName("address")]
        public Address? Address { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Land);
        }

        public bool Equals(Land? other)
        {
            return other is not null && base.Equals(other) && Address == other.Address;
        }

        public static bool operator ==(Land? left, Land? right)
        {
            return EqualityComparer<Land?>.Default.Equals(left, right);
        }

        public static bool operator !=(Land? left, Land? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Address?.GetHashCode());
        }
    }
}