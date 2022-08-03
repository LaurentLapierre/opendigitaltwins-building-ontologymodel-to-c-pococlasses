using Azure;
using Azure.DigitalTwins.Core;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace opendigitaltwins.building.digitaltwins.rec_3_3.device
{

    public class ResetState : DefaultState, IEquatable<ResetState>
    {
        public ResetState()
        {
            Metadata.ModelId = ModelId;
        }
        [JsonIgnore]
        public static new string ModelId { get; } = "dtmi:digitaltwins:rec_3_3:device:ResetState;1";
        public override bool Equals(object? obj)
        {
            return Equals(obj as ResetState);
        }

        public bool Equals(ResetState? other)
        {
            return other is not null && base.Equals(other);
        }

        public static bool operator ==(ResetState? left, ResetState? right)
        {
            return EqualityComparer<ResetState?>.Default.Equals(left, right);
        }

        public static bool operator !=(ResetState? left, ResetState? right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(base.GetHashCode());
        }
    }
}