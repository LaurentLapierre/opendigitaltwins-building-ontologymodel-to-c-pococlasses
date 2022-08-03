using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.fireprotectionequipmentgroup
{

    public class FireProtectionEquipmentGroupIncludesRelationship : Relationship<FireProtectionEquipment>, IEquatable<FireProtectionEquipmentGroupIncludesRelationship>
    {
        public FireProtectionEquipmentGroupIncludesRelationship()
        {
            Name = "includes";
        }

        public FireProtectionEquipmentGroupIncludesRelationship(FireProtectionEquipmentGroup source, FireProtectionEquipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as FireProtectionEquipmentGroupIncludesRelationship);
        }

        public bool Equals(FireProtectionEquipmentGroupIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(FireProtectionEquipmentGroupIncludesRelationship? left, FireProtectionEquipmentGroupIncludesRelationship? right)
        {
            return EqualityComparer<FireProtectionEquipmentGroupIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireProtectionEquipmentGroupIncludesRelationship? left, FireProtectionEquipmentGroupIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as FireProtectionEquipmentGroupIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}