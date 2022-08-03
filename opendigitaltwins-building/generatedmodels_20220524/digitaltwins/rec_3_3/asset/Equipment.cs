using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.equipment;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class Equipment : Asset, IEquatable<Equipment>
    {
        public Equipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:Equipment;1";
        [JsonIgnore]
        public EquipmentIsFedByRelationshipCollection IsFedBy { get; set; } = new EquipmentIsFedByRelationshipCollection();
        [JsonIgnore]
        public EquipmentFeedsRelationshipCollection Feeds { get; set; } = new EquipmentFeedsRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as Equipment);
        }

        public bool Equals(Equipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(Equipment? left, Equipment? right)
        {
            return EqualityComparer<Equipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(Equipment? left, Equipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}