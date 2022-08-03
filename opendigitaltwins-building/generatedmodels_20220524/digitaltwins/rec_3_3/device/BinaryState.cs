using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using opendigitaltwins.building.digitaltwins.rec_3_3.core;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class BinaryState : State, IEquatable<BinaryState>
    {
        public BinaryState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:BinaryState;1";
        [JsonPropertyName("lastValue")]
        public bool? LastValue { get; set; }
        public override bool Equals(object? obj)
        {
            return Equals(obj as BinaryState);
        }

        public bool Equals(BinaryState? other)
        {
            return other is not null && base.Equals(other) && LastValue == other.LastValue;
        }

        public static bool operator ==(BinaryState? left, BinaryState? right)
        {
            return EqualityComparer<BinaryState?>.Default.Equals(left, right);
        }

        public static bool operator !=(BinaryState? left, BinaryState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode(), LastValue?.GetHashCode());
        }
    }
}