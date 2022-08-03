using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class BinaryActuator : Actuator, IEquatable<BinaryActuator>
    {
        public BinaryActuator()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:BinaryActuator;1";
        [JsonPropertyName("lastValue")]
        public bool? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as BinaryActuator);
        }

        public bool Equals(BinaryActuator? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(BinaryActuator? left, BinaryActuator? right)
        {
            return EqualityComparer<BinaryActuator?>.Default.Equals(left, right);
        }

        public static bool operator !=(BinaryActuator? left, BinaryActuator? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}