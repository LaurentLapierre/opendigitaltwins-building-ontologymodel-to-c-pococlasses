using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class OverrideState : DefaultOverrideState, IEquatable<OverrideState>
    {
        public OverrideState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:OverrideState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as OverrideState);
        }

        public bool Equals(OverrideState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(OverrideState? left, OverrideState? right)
        {
            return EqualityComparer<OverrideState?>.Default.Equals(left, right);
        }

        public static bool operator !=(OverrideState? left, OverrideState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}