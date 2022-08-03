using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.conveyanceequipmentgroup;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ConveyanceEquipmentGroup : EquipmentGroup, IEquatable<ConveyanceEquipmentGroup>
    {
        public ConveyanceEquipmentGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ConveyanceEquipmentGroup;1";
        [JsonIgnore]
        public ConveyanceEquipmentGroupIncludesRelationshipCollection Includes { get; set; } = new ConveyanceEquipmentGroupIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as ConveyanceEquipmentGroup);
        }

        public bool Equals(ConveyanceEquipmentGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ConveyanceEquipmentGroup? left, ConveyanceEquipmentGroup? right)
        {
            return EqualityComparer<ConveyanceEquipmentGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(ConveyanceEquipmentGroup? left, ConveyanceEquipmentGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}