using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.electricalequipmentgroup;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ElectricalEquipmentGroup : EquipmentGroup, IEquatable<ElectricalEquipmentGroup>
    {
        public ElectricalEquipmentGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ElectricalEquipmentGroup;1";
        [JsonIgnore]
        public ElectricalEquipmentGroupIncludesRelationshipCollection Includes { get; set; } = new ElectricalEquipmentGroupIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalEquipmentGroup);
        }

        public bool Equals(ElectricalEquipmentGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ElectricalEquipmentGroup? left, ElectricalEquipmentGroup? right)
        {
            return EqualityComparer<ElectricalEquipmentGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalEquipmentGroup? left, ElectricalEquipmentGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}