using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.hvacequipmentgroup;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class HVACEquipmentGroup : EquipmentGroup, IEquatable<HVACEquipmentGroup>
    {
        public HVACEquipmentGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:HVACEquipmentGroup;1";
        [JsonIgnore]
        public HVACEquipmentGroupIncludesRelationshipCollection Includes { get; set; } = new HVACEquipmentGroupIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as HVACEquipmentGroup);
        }

        public bool Equals(HVACEquipmentGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(HVACEquipmentGroup? left, HVACEquipmentGroup? right)
        {
            return EqualityComparer<HVACEquipmentGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(HVACEquipmentGroup? left, HVACEquipmentGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}