using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.meterequipmentgroup;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class MeterEquipmentGroup : EquipmentGroup, IEquatable<MeterEquipmentGroup>
    {
        public MeterEquipmentGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:MeterEquipmentGroup;1";
        [JsonIgnore]
        public MeterEquipmentGroupIncludesRelationshipCollection Includes { get; set; } = new MeterEquipmentGroupIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as MeterEquipmentGroup);
        }

        public bool Equals(MeterEquipmentGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(MeterEquipmentGroup? left, MeterEquipmentGroup? right)
        {
            return EqualityComparer<MeterEquipmentGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(MeterEquipmentGroup? left, MeterEquipmentGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}