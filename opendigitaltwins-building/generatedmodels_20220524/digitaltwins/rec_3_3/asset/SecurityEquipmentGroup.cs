using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.securityequipmentgroup;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SecurityEquipmentGroup : EquipmentGroup, IEquatable<SecurityEquipmentGroup>
    {
        public SecurityEquipmentGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SecurityEquipmentGroup;1";
        [JsonIgnore]
        public SecurityEquipmentGroupIncludesRelationshipCollection Includes { get; set; } = new SecurityEquipmentGroupIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as SecurityEquipmentGroup);
        }

        public bool Equals(SecurityEquipmentGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(SecurityEquipmentGroup? left, SecurityEquipmentGroup? right)
        {
            return EqualityComparer<SecurityEquipmentGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(SecurityEquipmentGroup? left, SecurityEquipmentGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}