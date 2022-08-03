using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.plumbingequipmentgroup;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class PlumbingEquipmentGroup : EquipmentGroup, IEquatable<PlumbingEquipmentGroup>
    {
        public PlumbingEquipmentGroup()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:PlumbingEquipmentGroup;1";
        [JsonIgnore]
        public PlumbingEquipmentGroupIncludesRelationshipCollection Includes { get; set; } = new PlumbingEquipmentGroupIncludesRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as PlumbingEquipmentGroup);
        }

        public bool Equals(PlumbingEquipmentGroup? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PlumbingEquipmentGroup? left, PlumbingEquipmentGroup? right)
        {
            return EqualityComparer<PlumbingEquipmentGroup?>.Default.Equals(left, right);
        }

        public static bool operator !=(PlumbingEquipmentGroup? left, PlumbingEquipmentGroup? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}