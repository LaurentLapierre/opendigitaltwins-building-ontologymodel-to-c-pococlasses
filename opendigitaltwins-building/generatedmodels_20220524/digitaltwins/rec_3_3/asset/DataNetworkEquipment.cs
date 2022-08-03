using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.asset.relationship.datanetworkequipment;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class DataNetworkEquipment : ICTEquipment, IEquatable<DataNetworkEquipment>
    {
        public DataNetworkEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:DataNetworkEquipment;1";
        [JsonIgnore]
        public DataNetworkEquipmentMountedInRackRelationshipCollection MountedInRack { get; set; } = new DataNetworkEquipmentMountedInRackRelationshipCollection();
        public override bool Equals(object? obj)
        {
            return Equals(obj as DataNetworkEquipment);
        }

        public bool Equals(DataNetworkEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DataNetworkEquipment? left, DataNetworkEquipment? right)
        {
            return EqualityComparer<DataNetworkEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(DataNetworkEquipment? left, DataNetworkEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}