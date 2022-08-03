using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.buildingcomponent
{

    public class BuildingComponentIsPartOfRelationship : Relationship<BuildingComponent>, IEquatable<BuildingComponentIsPartOfRelationship>
    {
        public BuildingComponentIsPartOfRelationship()
        {
            Name = "isPartOf";
        }

        public BuildingComponentIsPartOfRelationship(BuildingComponent source, BuildingComponent target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BuildingComponentIsPartOfRelationship);
        }

        public bool Equals(BuildingComponentIsPartOfRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(BuildingComponentIsPartOfRelationship? left, BuildingComponentIsPartOfRelationship? right)
        {
            return EqualityComparer<BuildingComponentIsPartOfRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(BuildingComponentIsPartOfRelationship? left, BuildingComponentIsPartOfRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as BuildingComponentIsPartOfRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}