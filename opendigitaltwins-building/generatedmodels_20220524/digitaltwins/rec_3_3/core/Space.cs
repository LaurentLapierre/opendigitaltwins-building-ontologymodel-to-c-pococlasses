using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.space;
using opendigitaltwins.building.digitaltwins.rec_3_3;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Space : BasicDigitalTwin, IEquatable<Space>, IEquatable<BasicDigitalTwin>
    {
        public Space()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Space;1";
        [JsonPropertyName("personOccupancy")]
        public int? PersonOccupancy { get; set; }
        [JsonPropertyName("personCapacity")]
        public int? PersonCapacity { get; set; }
        [JsonIgnore]
        public SpaceServedByRelationshipCollection ServedBy { get; set; } = new SpaceServedByRelationshipCollection();
        [JsonIgnore]
        public SpaceOwnedByRelationshipCollection OwnedBy { get; set; } = new SpaceOwnedByRelationshipCollection();
        [JsonIgnore]
        public SpaceOperatedByRelationshipCollection OperatedBy { get; set; } = new SpaceOperatedByRelationshipCollection();
        [JsonIgnore]
        public SpaceIsPartOfRelationshipCollection IsPartOf { get; set; } = new SpaceIsPartOfRelationshipCollection();
        [JsonIgnore]
        public SpaceIncludedInRelationshipCollection IncludedIn { get; set; } = new SpaceIncludedInRelationshipCollection();
        [JsonIgnore]
        public SpaceHasPartRelationshipCollection HasPart { get; set; } = new SpaceHasPartRelationshipCollection();
        [JsonIgnore]
        public SpaceHasCapabilityRelationshipCollection HasCapability { get; set; } = new SpaceHasCapabilityRelationshipCollection();
        [JsonIgnore]
        public SpaceIsLocationOfRelationshipCollection IsLocationOf { get; set; } = new SpaceIsLocationOfRelationshipCollection();
        [JsonIgnore]
        public SpaceConstructedByRelationshipCollection ConstructedBy { get; set; } = new SpaceConstructedByRelationshipCollection();
        [JsonIgnore]
        public SpaceArchitectedByRelationshipCollection ArchitectedBy { get; set; } = new SpaceArchitectedByRelationshipCollection();
        [JsonPropertyName("customTags")]
        public IDictionary<string, string>? CustomTags { get; set; }
        [JsonPropertyName("externalIds")]
        public IDictionary<string, string>? ExternalIds { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("area")]
        public SpaceArea? Area { get; set; }
        [JsonPropertyName("capacity")]
        public SpaceCapacity? Capacity { get; set; }
        [JsonPropertyName("occupancy")]
        public SpaceOccupancy? Occupancy { get; set; }
        [JsonPropertyName("temperature")]
        public SpaceTemperature? Temperature { get; set; }
        [JsonPropertyName("humidity")]
        public SpaceHumidity? Humidity { get; set; }
        [JsonPropertyName("CO2")]
        public SpaceCO2? CO2 { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Space);
        }

        public bool Equals(Space? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && PersonOccupancy == other.PersonOccupancy && PersonCapacity == other.PersonCapacity && CustomTags == other.CustomTags && ExternalIds == other.ExternalIds && Name == other.Name && Area == other.Area && Capacity == other.Capacity && Occupancy == other.Occupancy && Temperature == other.Temperature && Humidity == other.Humidity && CO2 == other.CO2;
        }

        public static bool operator ==(Space? left, Space? right)
        {
            return EqualityComparer<Space?>.Default.Equals(left, right);
        }

        public static bool operator !=(Space? left, Space? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), PersonOccupancy?.GetHashCode(), PersonCapacity?.GetHashCode(), CustomTags?.GetHashCode(), ExternalIds?.GetHashCode(), Name?.GetHashCode(), Area?.GetHashCode(), Capacity?.GetHashCode(), Occupancy?.GetHashCode(), Temperature?.GetHashCode(), Humidity?.GetHashCode(), CO2?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as Space) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}