using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class OccupancySensorEquipment : SensorEquipment, IEquatable<OccupancySensorEquipment>
    {
        public OccupancySensorEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:OccupancySensorEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OccupancySensorEquipment);
        }

        public bool Equals(OccupancySensorEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OccupancySensorEquipment? left, OccupancySensorEquipment? right)
        {
            return EqualityComparer<OccupancySensorEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(OccupancySensorEquipment? left, OccupancySensorEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}