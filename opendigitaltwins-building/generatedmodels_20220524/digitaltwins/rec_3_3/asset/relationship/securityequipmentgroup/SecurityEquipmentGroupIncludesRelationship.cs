using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.securityequipmentgroup
{

    public class SecurityEquipmentGroupIncludesRelationship : Relationship<SecurityEquipment>, IEquatable<SecurityEquipmentGroupIncludesRelationship>
    {
        public SecurityEquipmentGroupIncludesRelationship()
        {
            Name = "includes";
        }

        public SecurityEquipmentGroupIncludesRelationship(SecurityEquipmentGroup source, SecurityEquipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SecurityEquipmentGroupIncludesRelationship);
        }

        public bool Equals(SecurityEquipmentGroupIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(SecurityEquipmentGroupIncludesRelationship? left, SecurityEquipmentGroupIncludesRelationship? right)
        {
            return EqualityComparer<SecurityEquipmentGroupIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(SecurityEquipmentGroupIncludesRelationship? left, SecurityEquipmentGroupIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SecurityEquipmentGroupIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}