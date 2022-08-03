using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.ictequipmentgroup
{

    public class ICTEquipmentGroupIncludesRelationship : Relationship<ICTEquipment>, IEquatable<ICTEquipmentGroupIncludesRelationship>
    {
        public ICTEquipmentGroupIncludesRelationship()
        {
            Name = "includes";
        }

        public ICTEquipmentGroupIncludesRelationship(ICTEquipmentGroup source, ICTEquipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ICTEquipmentGroupIncludesRelationship);
        }

        public bool Equals(ICTEquipmentGroupIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(ICTEquipmentGroupIncludesRelationship? left, ICTEquipmentGroupIncludesRelationship? right)
        {
            return EqualityComparer<ICTEquipmentGroupIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(ICTEquipmentGroupIncludesRelationship? left, ICTEquipmentGroupIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as ICTEquipmentGroupIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}