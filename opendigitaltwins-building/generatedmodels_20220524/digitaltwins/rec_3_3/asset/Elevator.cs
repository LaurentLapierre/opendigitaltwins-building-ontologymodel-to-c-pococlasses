using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Elevator : ConveyanceEquipment, IEquatable<Elevator>
    {
        public Elevator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Elevator;1";
        [JsonPropertyName("personCapacity")]
        public int? PersonCapacity { get; set; }
        [JsonPropertyName("weightCapacity")]
        public double? WeightCapacity { get; set; }
        [JsonPropertyName("maxTravelSpeed")]
        public double? MaxTravelSpeed { get; set; }
        [JsonPropertyName("maxTravelDistance")]
        public double? MaxTravelDistance { get; set; }
        [JsonPropertyName("maxLandings")]
        public int? MaxLandings { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Elevator);
        }

        public bool Equals(Elevator? other)
        {
            return other is not null && base.Equals(other) && PersonCapacity == other.PersonCapacity && WeightCapacity == other.WeightCapacity && MaxTravelSpeed == other.MaxTravelSpeed && MaxTravelDistance == other.MaxTravelDistance && MaxLandings == other.MaxLandings;
        }

        public static bool operator ==(Elevator? left, Elevator? right)
        {
            return EqualityComparer<Elevator?>.Default.Equals(left, right);
        }

        public static bool operator !=(Elevator? left, Elevator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), PersonCapacity?.GetHashCode(), WeightCapacity?.GetHashCode(), MaxTravelSpeed?.GetHashCode(), MaxTravelDistance?.GetHashCode(), MaxLandings?.GetHashCode());
        }
    }
}