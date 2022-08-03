using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.equipment
{

    public class EquipmentFeedsRelationship : Relationship<BasicDigitalTwin>, IEquatable<EquipmentFeedsRelationship>
    {
        public EquipmentFeedsRelationship()
        {
            Name = "feeds";
        }

        public EquipmentFeedsRelationship(Equipment source, BasicDigitalTwin target) : this()
        {
            InitializeFromTwins(source, target);
        }

        [JsonPropertyName("substance")]
        public EquipmentFeedsRelationshipSubstance? Substance { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentFeedsRelationship);
        }

        public bool Equals(EquipmentFeedsRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name && Substance == other.Substance;
        }

        public static bool operator ==(EquipmentFeedsRelationship? left, EquipmentFeedsRelationship? right)
        {
            return EqualityComparer<EquipmentFeedsRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentFeedsRelationship? left, EquipmentFeedsRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode(), Substance?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentFeedsRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}