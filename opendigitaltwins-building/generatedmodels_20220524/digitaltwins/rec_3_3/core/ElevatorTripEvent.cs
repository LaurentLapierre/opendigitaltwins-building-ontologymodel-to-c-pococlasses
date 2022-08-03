using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class ElevatorTripEvent : Event, IEquatable<ElevatorTripEvent>
    {
        public ElevatorTripEvent()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:ElevatorTripEvent;1";
        [JsonPropertyName("startLevelId")]
        public string? StartLevelId { get; set; }
        [JsonPropertyName("endLevelId")]
        public string? EndLevelId { get; set; }
        [JsonPropertyName("currentLevelId")]
        public string? CurrentLevelId { get; set; }
        [JsonPropertyName("currentTripDirection")]
        public ElevatorTripDirection? CurrentTripDirection { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElevatorTripEvent);
        }

        public bool Equals(ElevatorTripEvent? other)
        {
            return other is not null && base.Equals(other) && StartLevelId == other.StartLevelId && EndLevelId == other.EndLevelId && CurrentLevelId == other.CurrentLevelId && CurrentTripDirection == other.CurrentTripDirection;
        }

        public static bool operator ==(ElevatorTripEvent? left, ElevatorTripEvent? right)
        {
            return EqualityComparer<ElevatorTripEvent?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElevatorTripEvent? left, ElevatorTripEvent? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), StartLevelId?.GetHashCode(), EndLevelId?.GetHashCode(), CurrentLevelId?.GetHashCode(), CurrentTripDirection?.GetHashCode());
        }
    }
}