using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class BinarySensor : StateSensor, IEquatable<BinarySensor>
    {
        public BinarySensor()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:BinarySensor;1";
        [JsonPropertyName("lastValue")]
        public bool? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as BinarySensor);
        }

        public bool Equals(BinarySensor? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(BinarySensor? left, BinarySensor? right)
        {
            return EqualityComparer<BinarySensor?>.Default.Equals(left, right);
        }

        public static bool operator !=(BinarySensor? left, BinarySensor? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}