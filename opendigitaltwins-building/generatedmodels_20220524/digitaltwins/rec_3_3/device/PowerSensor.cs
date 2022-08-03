using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class PowerSensor : QuantitySensor, IEquatable<PowerSensor>
    {
        public PowerSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:PowerSensor;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as PowerSensor);
        }

        public bool Equals(PowerSensor? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(PowerSensor? left, PowerSensor? right)
        {
            return EqualityComparer<PowerSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(PowerSensor? left, PowerSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}