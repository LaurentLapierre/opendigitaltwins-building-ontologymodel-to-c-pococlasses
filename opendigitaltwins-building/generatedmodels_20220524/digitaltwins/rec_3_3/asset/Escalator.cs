using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Escalator : ConveyanceEquipment, IEquatable<Escalator>
    {
        public Escalator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Escalator;1";
        [JsonPropertyName("stepWidth")]
        public double? StepWidth { get; set; }
        [JsonPropertyName("maxVerticalRise")]
        public double? MaxVerticalRise { get; set; }
        [JsonPropertyName("maxTravelSpeed")]
        public double? MaxTravelSpeed { get; set; }
        [JsonPropertyName("inclination")]
        public double? Inclination { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Escalator);
        }

        public bool Equals(Escalator? other)
        {
            return other is not null && base.Equals(other) && StepWidth == other.StepWidth && MaxVerticalRise == other.MaxVerticalRise && MaxTravelSpeed == other.MaxTravelSpeed && Inclination == other.Inclination;
        }

        public static bool operator ==(Escalator? left, Escalator? right)
        {
            return EqualityComparer<Escalator?>.Default.Equals(left, right);
        }

        public static bool operator !=(Escalator? left, Escalator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), StepWidth?.GetHashCode(), MaxVerticalRise?.GetHashCode(), MaxTravelSpeed?.GetHashCode(), Inclination?.GetHashCode());
        }
    }
}