using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.asset
{

    public class SensorEquipment : ICTEquipment, IEquatable<SensorEquipment>
    {
        public SensorEquipment()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:asset:SensorEquipment;1";
        [JsonPropertyName("wifiSignalStrength")]
        public double? WifiSignalStrength { get; set; }
        [JsonPropertyName("batteryPercentage")]
        public double? BatteryPercentage { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as SensorEquipment);
        }

        public bool Equals(SensorEquipment? other)
        {
            return other is not null && base.Equals(other) && WifiSignalStrength == other.WifiSignalStrength && BatteryPercentage == other.BatteryPercentage;
        }

        public static bool operator ==(SensorEquipment? left, SensorEquipment? right)
        {
            return EqualityComparer<SensorEquipment?>.Default.Equals(left, right);
        }

        public static bool operator !=(SensorEquipment? left, SensorEquipment? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), WifiSignalStrength?.GetHashCode(), BatteryPercentage?.GetHashCode());
        }
    }
}