using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class CurrentImbalanceSensor : CurrentSensor, IEquatable<CurrentImbalanceSensor>
    {
        public CurrentImbalanceSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:CurrentImbalanceSensor;1";
        [JsonPropertyName("lastValue")]
        public double? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as CurrentImbalanceSensor);
        }

        public bool Equals(CurrentImbalanceSensor? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(CurrentImbalanceSensor? left, CurrentImbalanceSensor? right)
        {
            return EqualityComparer<CurrentImbalanceSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(CurrentImbalanceSensor? left, CurrentImbalanceSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}