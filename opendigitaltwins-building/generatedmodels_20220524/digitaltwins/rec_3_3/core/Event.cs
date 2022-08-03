using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Event : BasicDigitalTwin, IEquatable<Event>, IEquatable<BasicDigitalTwin>
    {
        public Event()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Event;1";
        [JsonPropertyName("hasUpdatedTime")]
        public DateTime? HasUpdatedTime { get; set; }
        [JsonPropertyName("hasTime")]
        public string? HasTime { get; set; }
        [JsonPropertyName("hasStopTime")]
        public DateTime? HasStopTime { get; set; }
        [JsonPropertyName("hasStartTime")]
        public DateTime? HasStartTime { get; set; }
        [JsonPropertyName("hasReadTime")]
        public DateTime? HasReadTime { get; set; }
        [JsonPropertyName("hasPointInTime")]
        public DateTime? HasPointInTime { get; set; }
        [JsonPropertyName("hasObservationTime")]
        public DateTime? HasObservationTime { get; set; }
        [JsonPropertyName("hasDuration")]
        public double? HasDuration { get; set; }
        [JsonPropertyName("hasDeletedTime")]
        public DateTime? HasDeletedTime { get; set; }
        [JsonPropertyName("hasCreatedTime")]
        public DateTime? HasCreatedTime { get; set; }
        [JsonPropertyName("customTags")]
        public IDictionary<string, string>? CustomTags { get; set; }
        [JsonPropertyName("externalIds")]
        public IDictionary<string, string>? ExternalIds { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Event);
        }

        public bool Equals(Event? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && HasUpdatedTime == other.HasUpdatedTime && HasTime == other.HasTime && HasStopTime == other.HasStopTime && HasStartTime == other.HasStartTime && HasReadTime == other.HasReadTime && HasPointInTime == other.HasPointInTime && HasObservationTime == other.HasObservationTime && HasDuration == other.HasDuration && HasDeletedTime == other.HasDeletedTime && HasCreatedTime == other.HasCreatedTime && CustomTags == other.CustomTags && ExternalIds == other.ExternalIds && Name == other.Name;
        }

        public static bool operator ==(Event? left, Event? right)
        {
            return EqualityComparer<Event?>.Default.Equals(left, right);
        }

        public static bool operator !=(Event? left, Event? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), HasUpdatedTime?.GetHashCode(), HasTime?.GetHashCode(), HasStopTime?.GetHashCode(), HasStartTime?.GetHashCode(), HasReadTime?.GetHashCode(), HasPointInTime?.GetHashCode(), HasObservationTime?.GetHashCode(), HasDuration?.GetHashCode(), HasDeletedTime?.GetHashCode(), HasCreatedTime?.GetHashCode(), CustomTags?.GetHashCode(), ExternalIds?.GetHashCode(), Name?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as Event) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}