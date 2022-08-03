using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.core.relationship.buildingcomponent
{

    public class BuildingComponentHasPartRelationship : Relationship<BuildingComponent>, IEquatable<BuildingComponentHasPartRelationship>
    {
        public BuildingComponentHasPartRelationship()
        {
            Name = "hasPart";
        }

        public BuildingComponentHasPartRelationship(BuildingComponent source, BuildingComponent target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BuildingComponentHasPartRelationship);
        }

        public bool Equals(BuildingComponentHasPartRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(BuildingComponentHasPartRelationship? left, BuildingComponentHasPartRelationship? right)
        {
            return EqualityComparer<BuildingComponentHasPartRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(BuildingComponentHasPartRelationship? left, BuildingComponentHasPartRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as BuildingComponentHasPartRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}