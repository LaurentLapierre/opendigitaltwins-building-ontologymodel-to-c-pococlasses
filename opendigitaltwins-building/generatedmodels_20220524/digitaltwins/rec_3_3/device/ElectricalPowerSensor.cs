using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ElectricalPowerSensor : PowerSensor, IEquatable<ElectricalPowerSensor>
    {
        public ElectricalPowerSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ElectricalPowerSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ElectricalPowerSensor);
        }

        public bool Equals(ElectricalPowerSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ElectricalPowerSensor? left, ElectricalPowerSensor? right)
        {
            return EqualityComparer<ElectricalPowerSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(ElectricalPowerSensor? left, ElectricalPowerSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}