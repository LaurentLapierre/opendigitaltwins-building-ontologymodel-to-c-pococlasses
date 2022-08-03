using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.addressing;
using opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.building;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core
{

    public class Building : Space, IEquatable<Building>
    {
        public Building()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:core:Building;1";
        [JsonPropertyName("address")]
        public Address? Address { get; set; }
        [JsonIgnore]
        public BuildingHasBuildingComponentRelationshipCollection HasBuildingComponent { get; set; } = new BuildingHasBuildingComponentRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as Building);
        }

        public bool Equals(Building? other)
        {
            return other is not null && base.Equals(other) && Address == other.Address;
        }

        public static bool operator ==(Building? left, Building? right)
        {
            return EqualityComparer<Building?>.Default.Equals(left, right);
        }

        public static bool operator !=(Building? left, Building? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), Address?.GetHashCode());
        }
    }
}