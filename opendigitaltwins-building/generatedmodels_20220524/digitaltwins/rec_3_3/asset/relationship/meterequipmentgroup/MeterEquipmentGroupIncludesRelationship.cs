using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.meterequipmentgroup
{

    public class MeterEquipmentGroupIncludesRelationship : Relationship<Meter>, IEquatable<MeterEquipmentGroupIncludesRelationship>
    {
        public MeterEquipmentGroupIncludesRelationship()
        {
            Name = "includes";
        }

        public MeterEquipmentGroupIncludesRelationship(MeterEquipmentGroup source, Meter target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as MeterEquipmentGroupIncludesRelationship);
        }

        public bool Equals(MeterEquipmentGroupIncludesRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name;
        }

        public static bool operator ==(MeterEquipmentGroupIncludesRelationship? left, MeterEquipmentGroupIncludesRelationship? right)
        {
            return EqualityComparer<MeterEquipmentGroupIncludesRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(MeterEquipmentGroupIncludesRelationship? left, MeterEquipmentGroupIncludesRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as MeterEquipmentGroupIncludesRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}