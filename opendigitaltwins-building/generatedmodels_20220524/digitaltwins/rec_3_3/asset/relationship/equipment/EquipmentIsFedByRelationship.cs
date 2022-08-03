using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.equipment
{

    public class EquipmentIsFedByRelationship : Relationship<BasicDigitalTwin>, IEquatable<EquipmentIsFedByRelationship>
    {
        public EquipmentIsFedByRelationship()
        {
            Name = "isFedBy";
        }

        public EquipmentIsFedByRelationship(Equipment source, BasicDigitalTwin target) : this()
        {
            InitializeFromTwins(source, target);
        }

        [JsonPropertyName("substance")]
        public EquipmentIsFedByRelationshipSubstance? Substance { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as EquipmentIsFedByRelationship);
        }

        public bool Equals(EquipmentIsFedByRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name && Substance == other.Substance;
        }

        public static bool operator ==(EquipmentIsFedByRelationship? left, EquipmentIsFedByRelationship? right)
        {
            return EqualityComparer<EquipmentIsFedByRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(EquipmentIsFedByRelationship? left, EquipmentIsFedByRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode(), Substance?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as EquipmentIsFedByRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}