using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3
{

    public class SpaceCapacity : BasicDigitalTwin, IEquatable<SpaceCapacity>, IEquatable<BasicDigitalTwin>
    {
        public SpaceCapacity()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:SpaceCapacity;1";
        [JsonPropertyName("maxOccupancy")]
        public int? MaxOccupancy { get; set; }
        [JsonPropertyName("seatingCapacity")]
        public int? SeatingCapacity { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as SpaceCapacity);
        }

        public bool Equals(SpaceCapacity? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && MaxOccupancy == other.MaxOccupancy && SeatingCapacity == other.SeatingCapacity;
        }

        public static bool operator ==(SpaceCapacity? left, SpaceCapacity? right)
        {
            return EqualityComparer<SpaceCapacity?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpaceCapacity? left, SpaceCapacity? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), MaxOccupancy?.GetHashCode(), SeatingCapacity?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as SpaceCapacity) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}