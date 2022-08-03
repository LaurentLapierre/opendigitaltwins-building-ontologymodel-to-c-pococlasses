using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class DefaultOverrideState : BinaryState, IEquatable<DefaultOverrideState>
    {
        public DefaultOverrideState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:DefaultOverrideState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DefaultOverrideState);
        }

        public bool Equals(DefaultOverrideState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DefaultOverrideState? left, DefaultOverrideState? right)
        {
            return EqualityComparer<DefaultOverrideState?>.Default.Equals(left, right);
        }

        public static bool operator !=(DefaultOverrideState? left, DefaultOverrideState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}