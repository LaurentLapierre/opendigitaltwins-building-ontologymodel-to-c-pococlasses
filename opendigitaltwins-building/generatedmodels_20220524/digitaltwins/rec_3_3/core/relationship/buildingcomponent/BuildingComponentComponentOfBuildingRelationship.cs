using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.buildingcomponent
{

    public class BuildingComponentComponentOfBuildingRelationship : Relationship<Building>, IEquatable<BuildingComponentComponentOfBuildingRelationship>
    {
        public BuildingComponentComponentOfBuildingRelationship()
        {
            Name = "componentOfBuilding";
        }

        public BuildingComponentComponentOfBuildingRelationship(BuildingComponent source, Building target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BuildingComponentComponentOfBuildingRelationship);
        }

        public bool Equals(BuildingComponentComponentOfBuildingRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(BuildingComponentComponentOfBuildingRelationship? left, BuildingComponentComponentOfBuildingRelationship? right)
        {
            return EqualityComparer<BuildingComponentComponentOfBuildingRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(BuildingComponentComponentOfBuildingRelationship? left, BuildingComponentComponentOfBuildingRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as BuildingComponentComponentOfBuildingRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}