using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.plumbingequipmentgroup
{

    public class PlumbingEquipmentGroupIncludesRelationship : Relationship<PlumbingEquipment>, IEquatable<PlumbingEquipmentGroupIncludesRelationship>
    {
        public PlumbingEquipmentGroupIncludesRelationship()
        {
            Name = "includes";
        }

        public PlumbingEquipmentGroupIncludesRelationship(PlumbingEquipmentGroup source, PlumbingEquipment target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingEquipmentGroupIncludesRelationship);
        }

        public bool Equals(PlumbingEquipmentGroupIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(PlumbingEquipmentGroupIncludesRelationship? left, PlumbingEquipmentGroupIncludesRelationship? right)
        {
            return EqualityComparer<PlumbingEquipmentGroupIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingEquipmentGroupIncludesRelationship? left, PlumbingEquipmentGroupIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as PlumbingEquipmentGroupIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}