using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.electricalequipmentgroup
{

    public class ElectricalEquipmentGroupIncludesRelationship : Relationship<ElectricalEquipment>, IEquatable<ElectricalEquipmentGroupIncludesRelationship>
    {
        public ElectricalEquipmentGroupIncludesRelationship()
        {
            Name = "includes";
        }

        public ElectricalEquipmentGroupIncludesRelationship(ElectricalEquipmentGroup source, ElectricalEquipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalEquipmentGroupIncludesRelationship);
        }

        public bool Equals(ElectricalEquipmentGroupIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ElectricalEquipmentGroupIncludesRelationship? left, ElectricalEquipmentGroupIncludesRelationship? right)
        {
            return EqualityComparer<ElectricalEquipmentGroupIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalEquipmentGroupIncludesRelationship? left, ElectricalEquipmentGroupIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ElectricalEquipmentGroupIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}