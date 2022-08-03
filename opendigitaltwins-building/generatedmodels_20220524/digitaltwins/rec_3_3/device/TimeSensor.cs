using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class TimeSensor : QuantitySensor, IEquatable<TimeSensor>
    {
        public TimeSensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:TimeSensor;1";
        [JsonPropertyName("lastValue")]
        public DateTime? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as TimeSensor);
        }

        public bool Equals(TimeSensor? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(TimeSensor? left, TimeSensor? right)
        {
            return EqualityComparer<TimeSensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(TimeSensor? left, TimeSensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}