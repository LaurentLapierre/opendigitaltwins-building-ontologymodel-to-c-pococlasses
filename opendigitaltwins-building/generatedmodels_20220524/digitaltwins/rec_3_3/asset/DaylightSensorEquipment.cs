using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class DaylightSensorEquipment : SensorEquipment, IEquatable<DaylightSensorEquipment>
    {
        public DaylightSensorEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:DaylightSensorEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DaylightSensorEquipment);
        }

        public bool Equals(DaylightSensorEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DaylightSensorEquipment? left, DaylightSensorEquipment? right)
        {
            return EqualityComparer<DaylightSensorEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(DaylightSensorEquipment? left, DaylightSensorEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}