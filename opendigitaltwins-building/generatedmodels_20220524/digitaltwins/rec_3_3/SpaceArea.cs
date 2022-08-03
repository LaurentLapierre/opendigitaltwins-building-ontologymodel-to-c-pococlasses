using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3
{

    public class SpaceArea : BasicDigitalTwin, IEquatable<SpaceArea>, IEquatable<BasicDigitalTwin>
    {
        public SpaceArea()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:SpaceArea;1";
        [JsonPropertyName("grossArea")]
        public double? GrossArea { get; set; }
        [JsonPropertyName("usableArea")]
        public double? UsableArea { get; set; }
        [JsonPropertyName("rentableArea")]
        public double? RentableArea { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as SpaceArea);
        }

        public bool Equals(SpaceArea? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && GrossArea == other.GrossArea && UsableArea == other.UsableArea && RentableArea == other.RentableArea;
        }

        public static bool operator ==(SpaceArea? left, SpaceArea? right)
        {
            return EqualityComparer<SpaceArea?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpaceArea? left, SpaceArea? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), GrossArea?.GetHashCode(), UsableArea?.GetHashCode(), RentableArea?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as SpaceArea) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}