using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.buildingcomponent;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class BuildingComponent : BasicDigitalTwin, IEquatable<BuildingComponent>, IEquatable<BasicDigitalTwin>
    {
        public BuildingComponent()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:BuildingComponent;1";
        [JsonIgnore]
        public BuildingComponentIsPartOfRelationshipCollection IsPartOf { get; set; } = new BuildingComponentIsPartOfRelationshipCollection();
        [JsonIgnore]
        public BuildingComponentHasPartRelationshipCollection HasPart { get; set; } = new BuildingComponentHasPartRelationshipCollection();
        [JsonIgnore]
        public BuildingComponentComponentOfBuildingRelationshipCollection ComponentOfBuilding { get; set; } = new BuildingComponentComponentOfBuildingRelationshipCollection();
        [JsonPropertyName("customTags")]
        public IDictionary<string, string>? CustomTags { get; set; }
        [JsonPropertyName("externalIds")]
        public IDictionary<string, string>? ExternalIds { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as BuildingComponent);
        }

        public bool Equals(BuildingComponent? other)
        {
            return other is not null && Id == other.Id && Metadata.ModelId == other.Metadata.ModelId && CustomTags == other.CustomTags && ExternalIds == other.ExternalIds && Name == other.Name;
        }

        public static bool operator ==(BuildingComponent? left, BuildingComponent? right)
        {
            return EqualityComparer<BuildingComponent?>.Default.Equals(left, right);
        }

        public static bool operator !=(BuildingComponent? left, BuildingComponent? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), Metadata?.ModelId?.GetHashCode(), CustomTags?.GetHashCode(), ExternalIds?.GetHashCode(), Name?.GetHashCode());
        }

        public bool Equals(BasicDigitalTwin? other)
        {
            return Equals(other as BuildingComponent) || new TwinEqualityComparer().Equals(this, other);
        }
    }
}