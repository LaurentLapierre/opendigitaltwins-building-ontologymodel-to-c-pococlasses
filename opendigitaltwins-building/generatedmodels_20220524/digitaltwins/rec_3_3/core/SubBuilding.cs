using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.addressing;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class SubBuilding : Space, IEquatable<SubBuilding>
    {
        public SubBuilding()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:SubBuilding;1";
        [JsonPropertyName("type")]
        public SubBuildingType? Type { get; set; }
        [JsonPropertyName("address")]
        public Address? Address { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as SubBuilding);
        }

        public bool Equals(SubBuilding? other)
        {
            return other is not null && base.Equals(other) && Type == other.Type && Address == other.Address;
        }

        public static bool operator ==(SubBuilding? left, SubBuilding? right)
        {
            return EqualityComparer<SubBuilding?>.Default.Equals(left, right);
        }

        public static bool operator !=(SubBuilding? left, SubBuilding? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Type?.GetHashCode(), Address?.GetHashCode());
        }
    }
}