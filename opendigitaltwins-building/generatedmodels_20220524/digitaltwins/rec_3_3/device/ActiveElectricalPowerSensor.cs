using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ActiveElectricalPowerSensor : ElectricalPowerSensor, IEquatable<ActiveElectricalPowerSensor>
    {
        public ActiveElectricalPowerSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ActiveElectricalPowerSensor;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as ActiveElectricalPowerSensor);
        }

        public bool Equals(ActiveElectricalPowerSensor? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(ActiveElectricalPowerSensor? left, ActiveElectricalPowerSensor? right)
        {
            return EqualityComparer<ActiveElectricalPowerSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(ActiveElectricalPowerSensor? left, ActiveElectricalPowerSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}