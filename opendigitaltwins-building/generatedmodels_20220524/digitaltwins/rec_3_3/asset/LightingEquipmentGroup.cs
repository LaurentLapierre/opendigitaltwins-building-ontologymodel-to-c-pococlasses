using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.lightingequipmentgroup;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class LightingEquipmentGroup : EquipmentGroup, IEquatable<LightingEquipmentGroup>
    {
        public LightingEquipmentGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:LightingEquipmentGroup;1";
        [JsonIgnore]
        public LightingEquipmentGroupIncludesRelationshipCollection Includes { get; set; } = new LightingEquipmentGroupIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as LightingEquipmentGroup);
        }

        public bool Equals(LightingEquipmentGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(LightingEquipmentGroup? left, LightingEquipmentGroup? right)
        {
            return EqualityComparer<LightingEquipmentGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(LightingEquipmentGroup? left, LightingEquipmentGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}