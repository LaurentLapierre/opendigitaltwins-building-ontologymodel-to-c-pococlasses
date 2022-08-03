using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.lightingequipmentgroup
{

    public class LightingEquipmentGroupIncludesRelationship : Relationship<LightingEquipment>, IEquatable<LightingEquipmentGroupIncludesRelationship>
    {
        public LightingEquipmentGroupIncludesRelationship()
        {
            Name = "includes";
        }

        public LightingEquipmentGroupIncludesRelationship(LightingEquipmentGroup source, LightingEquipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as LightingEquipmentGroupIncludesRelationship);
        }

        public bool Equals(LightingEquipmentGroupIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(LightingEquipmentGroupIncludesRelationship? left, LightingEquipmentGroupIncludesRelationship? right)
        {
            return EqualityComparer<LightingEquipmentGroupIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(LightingEquipmentGroupIncludesRelationship? left, LightingEquipmentGroupIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as LightingEquipmentGroupIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}