using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class MovingWalkway : ConveyanceEquipment, IEquatable<MovingWalkway>
    {
        public MovingWalkway()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:MovingWalkway;1";
        [JsonPropertyName("stepWidth")]
        public double? StepWidth { get; set; }
        [JsonPropertyName("maxTravelSpeed")]
        public double? MaxTravelSpeed { get; set; }
        [JsonPropertyName("maxLength")]
        public double? MaxLength { get; set; }
        [JsonPropertyName("inclination")]
        public double? Inclination { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as MovingWalkway);
        }

        public bool Equals(MovingWalkway? other)
        {
            return other is not null && base.Equals(other) && StepWidth == other.StepWidth && MaxTravelSpeed == other.MaxTravelSpeed && MaxLength == other.MaxLength && Inclination == other.Inclination;
        }

        public static bool operator ==(MovingWalkway? left, MovingWalkway? right)
        {
            return EqualityComparer<MovingWalkway?>.Default.Equals(left, right);
        }

        public static bool operator !=(MovingWalkway? left, MovingWalkway? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), StepWidth?.GetHashCode(), MaxTravelSpeed?.GetHashCode(), MaxLength?.GetHashCode(), Inclination?.GetHashCode());
        }
    }
}