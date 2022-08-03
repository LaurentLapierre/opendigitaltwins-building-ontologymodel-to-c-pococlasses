using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3
{

    public class SpaceOccupancy : BasicDigitalTwin, IEquatable<SpaceOccupancy>, IEquatable<BasicDigitalTwin>
    {
        public SpaceOccupancy()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:SpaceOccupancy;1";
        [JsonPropertyName("isOccupied")]
        public bool? IsOccupied { get; set; }
        [JsonPropertyName("peopleCount")]
        public double? PeopleCount { get; set; }
        [JsonPropertyName("hasInferredOccupancy")]
        public bool? HasInferredOccupancy { get; set; }
        [JsonPropertyName("dwellTimeAverage")]
        public double? DwellTimeAverage { get; set; }
        [JsonPropertyName("entranceDwellTime")]
        public double? EntranceDwellTime { get; set; }
        [JsonPropertyName("exitDwellTime")]
        public double? ExitDwellTime { get; set; }
        [JsonPropertyName("entranceRate")]
        public double? EntranceRate { get; set; }
        [JsonPropertyName("exitRate")]
        public double? ExitRate { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as SpaceOccupancy);
        }

        public bool Equals(SpaceOccupancy? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && IsOccupied == other.IsOccupied && PeopleCount == other.PeopleCount && HasInferredOccupancy == other.HasInferredOccupancy && DwellTimeAverage == other.DwellTimeAverage && EntranceDwellTime == other.EntranceDwellTime && ExitDwellTime == other.ExitDwellTime && EntranceRate == other.EntranceRate && ExitRate == other.ExitRate;
        }

        public static bool operator ==(SpaceOccupancy? left, SpaceOccupancy? right)
        {
            return EqualityComparer<SpaceOccupancy?>.Default.Equals(left, right);
        }

        public static bool operator !=(SpaceOccupancy? left, SpaceOccupancy? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), IsOccupied?.GetHashCode(), PeopleCount?.GetHashCode(), HasInferredOccupancy?.GetHashCode(), DwellTimeAverage?.GetHashCode(), EntranceDwellTime?.GetHashCode(), ExitDwellTime?.GetHashCode(), EntranceRate?.GetHashCode(), ExitRate?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as SpaceOccupancy) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}