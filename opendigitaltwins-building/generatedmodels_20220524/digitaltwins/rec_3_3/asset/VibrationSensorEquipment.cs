using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class VibrationSensorEquipment : SensorEquipment, IEquatable<VibrationSensorEquipment>
    {
        public VibrationSensorEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:VibrationSensorEquipment;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as VibrationSensorEquipment);
        }

        public bool Equals(VibrationSensorEquipment? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(VibrationSensorEquipment? left, VibrationSensorEquipment? right)
        {
            return EqualityComparer<VibrationSensorEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(VibrationSensorEquipment? left, VibrationSensorEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}