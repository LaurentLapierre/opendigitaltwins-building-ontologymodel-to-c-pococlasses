using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.hvacequipmentgroup
{

    public class HVACEquipmentGroupIncludesRelationship : Relationship<HVACEquipment>, IEquatable<HVACEquipmentGroupIncludesRelationship>
    {
        public HVACEquipmentGroupIncludesRelationship()
        {
            Name = "includes";
        }

        public HVACEquipmentGroupIncludesRelationship(HVACEquipmentGroup source, HVACEquipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACEquipmentGroupIncludesRelationship);
        }

        public bool Equals(HVACEquipmentGroupIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(HVACEquipmentGroupIncludesRelationship? left, HVACEquipmentGroupIncludesRelationship? right)
        {
            return EqualityComparer<HVACEquipmentGroupIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACEquipmentGroupIncludesRelationship? left, HVACEquipmentGroupIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as HVACEquipmentGroupIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}