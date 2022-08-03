using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.ictequipmentgroup;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class ICTEquipmentGroup : EquipmentGroup, IEquatable<ICTEquipmentGroup>
    {
        public ICTEquipmentGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:ICTEquipmentGroup;1";
        [JsonIgnore]
        public ICTEquipmentGroupIncludesRelationshipCollection Includes { get; set; } = new ICTEquipmentGroupIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as ICTEquipmentGroup);
        }

        public bool Equals(ICTEquipmentGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ICTEquipmentGroup? left, ICTEquipmentGroup? right)
        {
            return EqualityComparer<ICTEquipmentGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(ICTEquipmentGroup? left, ICTEquipmentGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}