using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class DefaultState : DefaultOverrideState, IEquatable<DefaultState>
    {
        public DefaultState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:DefaultState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as DefaultState);
        }

        public bool Equals(DefaultState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(DefaultState? left, DefaultState? right)
        {
            return EqualityComparer<DefaultState?>.Default.Equals(left, right);
        }

        public static bool operator !=(DefaultState? left, DefaultState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}