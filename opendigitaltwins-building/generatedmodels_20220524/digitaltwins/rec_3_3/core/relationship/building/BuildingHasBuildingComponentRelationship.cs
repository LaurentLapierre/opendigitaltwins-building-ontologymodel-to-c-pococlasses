using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.building
{

    public class BuildingHasBuildingComponentRelationship : Relationship<BuildingComponent>, IEquatable<BuildingHasBuildingComponentRelationship>
    {
        public BuildingHasBuildingComponentRelationship()
        {
            Name = "hasBuildingComponent";
        }

        public BuildingHasBuildingComponentRelationship(Building source, BuildingComponent target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BuildingHasBuildingComponentRelationship);
        }

        public bool Equals(BuildingHasBuildingComponentRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(BuildingHasBuildingComponentRelationship? left, BuildingHasBuildingComponentRelationship? right)
        {
            return EqualityComparer<BuildingHasBuildingComponentRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(BuildingHasBuildingComponentRelationship? left, BuildingHasBuildingComponentRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as BuildingHasBuildingComponentRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}