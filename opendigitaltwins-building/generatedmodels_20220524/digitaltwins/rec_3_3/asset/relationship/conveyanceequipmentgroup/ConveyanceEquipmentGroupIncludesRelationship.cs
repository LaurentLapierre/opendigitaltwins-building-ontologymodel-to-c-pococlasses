using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.conveyanceequipmentgroup
{

    public class ConveyanceEquipmentGroupIncludesRelationship : Relationship<ConveyanceEquipment>, IEquatable<ConveyanceEquipmentGroupIncludesRelationship>
    {
        public ConveyanceEquipmentGroupIncludesRelationship()
        {
            Name = "includes";
        }

        public ConveyanceEquipmentGroupIncludesRelationship(ConveyanceEquipmentGroup source, ConveyanceEquipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ConveyanceEquipmentGroupIncludesRelationship);
        }

        public bool Equals(ConveyanceEquipmentGroupIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ConveyanceEquipmentGroupIncludesRelationship? left, ConveyanceEquipmentGroupIncludesRelationship? right)
        {
            return EqualityComparer<ConveyanceEquipmentGroupIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ConveyanceEquipmentGroupIncludesRelationship? left, ConveyanceEquipmentGroupIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ConveyanceEquipmentGroupIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}