using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.fireprotectionequipmentgroup;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class FireProtectionEquipmentGroup : EquipmentGroup, IEquatable<FireProtectionEquipmentGroup>
    {
        public FireProtectionEquipmentGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:FireProtectionEquipmentGroup;1";
        [JsonIgnore]
        public FireProtectionEquipmentGroupIncludesRelationshipCollection Includes { get; set; } = new FireProtectionEquipmentGroupIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as FireProtectionEquipmentGroup);
        }

        public bool Equals(FireProtectionEquipmentGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(FireProtectionEquipmentGroup? left, FireProtectionEquipmentGroup? right)
        {
            return EqualityComparer<FireProtectionEquipmentGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(FireProtectionEquipmentGroup? left, FireProtectionEquipmentGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}