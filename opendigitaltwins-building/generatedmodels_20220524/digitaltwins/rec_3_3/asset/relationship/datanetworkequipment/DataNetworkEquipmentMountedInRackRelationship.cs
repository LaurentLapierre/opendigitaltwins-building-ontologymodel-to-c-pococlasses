using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.datanetworkequipment
{

    public class DataNetworkEquipmentMountedInRackRelationship : Relationship<ITRack>, IEquatable<DataNetworkEquipmentMountedInRackRelationship>
    {
        public DataNetworkEquipmentMountedInRackRelationship()
        {
            Name = "mountedInRack";
        }

        public DataNetworkEquipmentMountedInRackRelationship(DataNetworkEquipment source, ITRack target) : this()
        {
            InitializeFromTwins(source, target);
        }

        [JsonPropertyName("rackTopPosition")]
        public int? RackTopPosition { get; set; }
        [JsonPropertyName("rackBottomPosition")]
        public int? RackBottomPosition { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as DataNetworkEquipmentMountedInRackRelationship);
        }

        public bool Equals(DataNetworkEquipmentMountedInRackRelationship? other)
        {
            return other is not null && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && Target == other.Target && Name == other.Name && RackTopPosition == other.RackTopPosition && RackBottomPosition == other.RackBottomPosition;
        }

        public static bool operator ==(DataNetworkEquipmentMountedInRackRelationship? left, DataNetworkEquipmentMountedInRackRelationship? right)
        {
            return EqualityComparer<DataNetworkEquipmentMountedInRackRelationship?>.Default.Equals(left, right);
        }

        public static bool operator !=(DataNetworkEquipmentMountedInRackRelationship? left, DataNetworkEquipmentMountedInRackRelationship? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode(), RackTopPosition?.GetHashCode(), RackBottomPosition?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as DataNetworkEquipmentMountedInRackRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}